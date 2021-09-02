//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public SequenceManager sequencemanager;
    public InputManager inputmanager;
    public SoundEffects soundeffects;
    public DisplayManager displaymanager;

    public GameObject BoardPrefab;
    public GameObject HeliPrefab;

    [HideInInspector]
    public Board board;
    [HideInInspector]
    public Heli heli;

    public bool isPlaying;
    public int iLevel;
    


    void Start() {
        setupGame();
        
    }

    private void setupGame() {
        board = Instantiate(BoardPrefab, Vector3.zero, Quaternion.identity).GetComponent<Board>();
        board.gamemanager = this;
        board.setupBoard();

        heli = Instantiate(HeliPrefab, Vector3.zero, Quaternion.identity).GetComponent<Heli>();
        heli.gamemanager = this;
        heli.setupHeli();

        iLevel = 0;
        isPlaying = true;

    }

    void Update() {
        
    }

    public void doLevelComplete() {
        displaymanager.showLevelComplete();
        isPlaying = false;
    }

    public void doGameOver() {
        displaymanager.showGameOver();
        isPlaying = false;
    }

    public void doNextLevel() {
        Debug.Log("doNextLevel");
        displaymanager.hideLevelComplete();
        iLevel++;

        heli.setupHeli();
        board.restart();
        isPlaying = true;

    }

    public void returnToTile() {
        SceneManager.LoadScene("title");
    }
}
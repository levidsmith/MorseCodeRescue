//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public SequenceManager sequencemanager;
    public InputManager inputmanager;
    public SoundEffects soundeffects;

    public GameObject BoardPrefab;
    [HideInInspector]
    public Board board;


    void Start() {
        setupGame();
        
    }

    private void setupGame() {
        board = Instantiate(BoardPrefab, Vector3.zero, Quaternion.identity).GetComponent<Board>();
        board.gamemanager = this;
        board.setupBoard();

    }

    void Update() {
        
    }
}
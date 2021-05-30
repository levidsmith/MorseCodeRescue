//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayManager : MonoBehaviour {

    public Text TextDownTime;
    public Text TextUpTime;
    public Text TextMessage;

    public GameManager gamemanager;

    public GameObject panelLevelComplete;
    public GameObject panelGameOver;

    void Start() {
        
    }

    void Update() {
        TextDownTime.text = string.Format("{0:0.00}", gamemanager.inputmanager.fDownTime);
        TextUpTime.text = string.Format("{0:0.00}", gamemanager.inputmanager.fUpTime);
        TextMessage.text = gamemanager.inputmanager.strMessage;

    }

    public void showLevelComplete() {
        panelLevelComplete.SetActive(true);

    }

    public void showGameOver() {
        panelGameOver.SetActive(true);
    }
}
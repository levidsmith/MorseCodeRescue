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

    void Start() {
        
    }

    void Update() {
        TextDownTime.text = string.Format("{0:0.00}", gamemanager.inputmanager.fDownTime);
        TextUpTime.text = string.Format("{0:0.00}", gamemanager.inputmanager.fUpTime);
        TextMessage.text = gamemanager.inputmanager.strMessage;

    }
}
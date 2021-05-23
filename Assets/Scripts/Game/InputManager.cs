//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
    float fUnitLength = 0.1f;
    [HideInInspector]
    public string strMessage;
    
    bool isDown;
    bool isTranslated;

    [HideInInspector]
    public float fDownTime;
    [HideInInspector]
    public float fUpTime;

    List<int> iInputSequence;

    public GameManager gamemanager;
    

    void Start() {
        strMessage = "";
        isDown = false;
        isTranslated = true; //don't need to translate at the beginning
        iInputSequence = new List<int>();
        
    }

    void Update() {
        if (Input.GetButtonDown("Submit")) {
            Debug.Log("Button down");
            if (!isDown) {
                fDownTime = 0f;
                isDown = true;
                isTranslated = false;
                gamemanager.soundeffects.SoundOriginal.Play();
//                translateUpTime();
            }

        } else if (Input.GetButtonUp("Submit")) {
            Debug.Log("Button up");
            if (isDown) {
                translateDownTime();
                isDown = false;
                fUpTime = 0f;
                gamemanager.soundeffects.SoundOriginal.Stop();

            }
            

        } else {
            if (isDown) {
                fDownTime += Time.deltaTime;
            } else {
                fUpTime += Time.deltaTime;
                if (!isTranslated && fUpTime >= fUnitLength * 3f) {
                    translateLetter();
                }
            }

        }
    }

    private void translateDownTime() {
        if (fDownTime >= fUnitLength * 3f) {
            strMessage += "-";
            iInputSequence.Add(1);
        } else if (fDownTime >= fUnitLength * 1f) {
            strMessage += ".";
            iInputSequence.Add(0);
        }

    }

    private void translateUpTime() {
        if (fUpTime >= fUnitLength * 3f) {
            translateLetter();
        } else {

        }
            //strMessage += " ";

    }

    private void translateLetter() {

        if (iInputSequence.Count > 0) {
            char chValue = gamemanager.sequencemanager.getValue(iInputSequence);
            strMessage += "(" + chValue + ")";
            gamemanager.board.selectRowColumn(chValue);
            isTranslated = true;
        }


        iInputSequence = new List<int>();


    }
}
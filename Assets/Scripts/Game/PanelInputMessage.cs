//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelInputMessage : MonoBehaviour {
    public Text textInputMessage;
    public Text textInputMessageTranslate;
    public string strMessage;
    public string strMessageTranslate;
    
    void Start() {
        
    }

    void Update() {
        textInputMessage.text = strMessage;
        textInputMessageTranslate.text = strMessageTranslate;
        
    }
}
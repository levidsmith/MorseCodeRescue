//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RowColumnLabel : MonoBehaviour {

    public Text textValue;
    public Text textCode;

    public bool isSelected;
    public Image imgBkg;

    void Start() {
        isSelected = false;
        
    }

    void Update() {
        
    }

    public void setValue(string in_strValue, string in_strCode) {
        textValue.text = in_strValue;
        textCode.text = in_strCode;

    }

    public void setSelected(bool in_isSelected) {
        isSelected = in_isSelected;
        if (isSelected) {
            imgBkg.color = Color.red;
        } else {
            imgBkg.color = Color.blue;
        }

    }
}
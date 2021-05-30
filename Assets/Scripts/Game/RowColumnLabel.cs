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
    private Color colorDefault;
    private Color colorSelected;

    void Start() {
        isSelected = false;
        colorDefault = imgBkg.color;
        colorSelected = Color.red;
        
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
            imgBkg.color = colorSelected;
        } else {
            imgBkg.color = colorDefault;
        }

    }
}
//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RowColumnLabel : MonoBehaviour {

    public Text textValue;

    void Start() {
        
    }

    void Update() {
        
    }

    public void setValue(string in_strValue) {
        textValue.text = in_strValue;

    }
}
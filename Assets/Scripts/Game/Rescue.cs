//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rescue : MonoBehaviour {
    public bool isRescued;
    public GameObject model;

    void Start() {
        isRescued = false;
        
    }

    void Update() {
        
    }

    public void setRescued(bool in_isRescued) {
        isRescued = in_isRescued;
        if (isRescued) {
            model.SetActive(false);
        }

    }

    
}
//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayManager : MonoBehaviour {

    public Text TextDownTime;
    public Text TextUpTime;
    public Text TextMessage;
    public Text TextLevel;

    public GameManager gamemanager;

    public GameObject panelLevelComplete;
    public GameObject panelGameOver;

    public GameObject panelInputMessagePrefab;

    public PanelInputMessage currentPanelInputMessage = null;
    public List<PanelInputMessage> panelInputMessages;

    void Start() {
        panelInputMessages = new List<PanelInputMessage>();
        createPanelInputMessage();
        
    }

    void Update() {
        TextDownTime.text = string.Format("{0:0.00}", gamemanager.inputmanager.fDownTime);
        TextUpTime.text = string.Format("{0:0.00}", gamemanager.inputmanager.fUpTime);
        //TextMessage.text = gamemanager.inputmanager.strMessage;
        TextLevel.text = string.Format("Level {0:0}", gamemanager.iLevel + 1);

        if (currentPanelInputMessage != null) {
            currentPanelInputMessage.strMessage = gamemanager.inputmanager.strMessage;
        }

    }

    public void showLevelComplete() {
        panelLevelComplete.SetActive(true);

    }

    public void hideLevelComplete() {
        panelLevelComplete.SetActive(false);

    }

    public void showGameOver() {
        panelGameOver.SetActive(true);
    }

    public void createPanelInputMessage() {
        Debug.Log("createPanelInputMessage");
        GameObject gobj = Instantiate(panelInputMessagePrefab, Vector3.zero, Quaternion.identity);
        gobj.transform.SetParent(GetComponentInChildren<Canvas>().transform, false);
        gobj.transform.localPosition = new Vector3(-400f, 0f, 0f);
        
        currentPanelInputMessage = gobj.GetComponent<PanelInputMessage>();
        panelInputMessages.Add(currentPanelInputMessage);

        //keep the panels from going off the top of the screen
        int iMaxInputPanels = 12;
        if (panelInputMessages.Count > iMaxInputPanels) {
            while (panelInputMessages.Count > iMaxInputPanels) {
                PanelInputMessage panelRemove = panelInputMessages[0];
                panelInputMessages.Remove(panelRemove);
                DestroyImmediate(panelRemove.gameObject);
            }
        }

        int iPosition = 0;
        foreach (PanelInputMessage panel in panelInputMessages) {
            panel.transform.localPosition = new Vector2((-1920/2) + 32, -400 + (iPosition * 52f));
                iPosition++;
        }

    }
}
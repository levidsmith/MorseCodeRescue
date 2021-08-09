//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heli : MonoBehaviour {

    public Vector3 posHome;
    public Cell targetCell;
    float fSpeed = 5f;
//    private float fResuceCountdown;
    public GameManager gamemanager;
    public float fFuel;
    public Text TextFuel;

    public float fMaxFuel = 20f;

    void Start() {
        targetCell = null;
        
    }

    void Update() {

        if (gamemanager.isPlaying) {
            updateHeli();
        }




    }

    private void updateHeli() {
        if (targetCell != null) {
            moveToCell();
        } else {
            fFuel -= Time.deltaTime * 0.05f;
        }

        TextFuel.text = string.Format("{0:0.00}", fFuel);

        if (fFuel <= 0f) {
            gamemanager.doGameOver();
        }
    }


    public void startRescue(Cell in_cell) {
        targetCell = in_cell;

    }

    private void moveToCell() {
        float fDistance;
        float fDistanceMoved = 0f;
        fDistance = Vector3.Distance(transform.position, targetCell.transform.position);
        if (fDistance <= fSpeed * Time.deltaTime) {
  //          fResuceCountdown = 1f;
            transform.position = targetCell.transform.position;
            fDistanceMoved = fDistance;
            doRescue(targetCell);
        } else {
            transform.position = Vector3.MoveTowards(transform.position, targetCell.transform.position, fSpeed * Time.deltaTime);
            fDistanceMoved = fSpeed * Time.deltaTime;
        }

        fFuel -= fDistanceMoved;
        
    }
    private void doRescue(Cell in_Cell) {
        Rescue rescue = gamemanager.board.getRescue(in_Cell);
        if (rescue != null) {
            rescue.setRescued(true);
            gamemanager.soundeffects.SoundPickup.Play();

        }

        Fuel fuel = gamemanager.board.getFuel(in_Cell);
        if (fuel != null) {
            fuel.doPickup();
            addFuel(10f);
            gamemanager.soundeffects.SoundFuel.Play();

        }

        gamemanager.board.resetSelectedRowCol();
        targetCell = null;

        gamemanager.board.checkLevelComplete();

    }

    /*
     private bool getIsRescuing() {
        bool isRescuing = false;
        if (fResuceCountdown > 0f) {
            isRescuing = true;
        }
        return isRescuing;
    }
    */

    public void setupHeli() {
        posHome = new Vector3(-1f, 0f, gamemanager.board.iRows);
        transform.position = posHome;
        fFuel = 20f;
    }

    private void addFuel(float in_fAmount) {
        fFuel += in_fAmount;
        if (fFuel >= fMaxFuel) {
            fFuel = fMaxFuel;
        }
    }



}
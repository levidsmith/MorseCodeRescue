//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

    public GameObject CellPrefab;
    public GameObject RowColumnLabelPrefab;
    public GameObject RescuePrefab;

    int iRows, iCols;

    public GameManager gamemanager;
    List<RowColumnLabel> rowLabels;
    List<RowColumnLabel> colLabels;

    void Start() {
        
    }

    public void setupBoard() {
        iRows = 5;
        iCols = 5;
        setupCells();
        setupRescue();

    }


    private void setupCells() {
        int i, j;
        for (i = 0; i < iRows; i++) {
            for (j = 0; j < iCols; j++) {
                Vector3 pos = new Vector3(j, 0f, i);

                Cell cell = Instantiate(CellPrefab, pos, Quaternion.identity).GetComponent<Cell>();

                cell.transform.SetParent(this.transform);
            }
        }


        if (gamemanager == null) {
            Debug.Log("gamemanager is null");
        }

        if (gamemanager.sequencemanager == null) {
            Debug.Log("sequencemanager is null");
        }


        rowLabels = new List<RowColumnLabel>();
        colLabels = new List<RowColumnLabel>();

        float fOffsetX;
        float fOffsetZ;
        fOffsetX = -1f;
        fOffsetZ = iRows - 1f;
        for (i = 0; i < iRows; i++) {
            Vector3 pos = new Vector3(fOffsetX, 0f, fOffsetZ - i);

            RowColumnLabel rowcolumnlabel = Instantiate(RowColumnLabelPrefab, pos, Quaternion.identity).GetComponent<RowColumnLabel>();
            char ch = (char)(((int)'1') + i);
            rowcolumnlabel.setValue("" + ch, gamemanager.sequencemanager.getCode(ch));
            rowLabels.Add(rowcolumnlabel);
        }

        fOffsetX = 0f;
        fOffsetZ = iRows;
        for (j = 0; j < iCols; j++) {
            Vector3 pos = new Vector3(fOffsetX + j, 0f, fOffsetZ);

            RowColumnLabel rowcolumnlabel = Instantiate(RowColumnLabelPrefab, pos, Quaternion.identity).GetComponent<RowColumnLabel>();
            char ch = (char)(((int)'A') + j);



            rowcolumnlabel.setValue("" + ch, gamemanager.sequencemanager.getCode(ch));
            colLabels.Add(rowcolumnlabel);
        }


    }

    private void setupRescue() {
        int iRescueCount = 2;

        int i;
        int iRandRow, iRandCol;
        for (i = 0; i < iRescueCount; i++) {
            iRandRow = Random.Range(0, iRows);
            iRandCol = Random.Range(0, iCols);
            Instantiate(RescuePrefab, new Vector3(iRandRow, 0f, iRandCol), Quaternion.identity);
        }
    }



    void Update() {
        
    }

    public void selectRowColumn(char in_ch) {
        foreach (RowColumnLabel rowLabel in rowLabels) {
            if (rowLabel.textValue.text[0] == in_ch) {
                unselectAllRows();
                rowLabel.setSelected(true);
            }
        }

        foreach (RowColumnLabel colLabel in colLabels) {
            if (colLabel.textValue.text[0] == in_ch) {
                unselectAllCols();
                colLabel.setSelected(true);
            }
        }
    }


    private void unselectAllRows() {
        foreach (RowColumnLabel rowLabel in rowLabels) {
            rowLabel.setSelected(false);
        }

    }

    private void unselectAllCols() {
        foreach(RowColumnLabel colLabel in colLabels) {
            colLabel.setSelected(false);
        }

    }
}
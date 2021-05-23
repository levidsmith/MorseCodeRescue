//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

    public GameObject CellPrefab;
    public GameObject RowColumnLabelPrefab;
    int iRows, iCols;

    void Start() {
        iRows = 5;
        iCols = 5;
        setupCells();
        
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


        float fOffsetX;
        float fOffsetZ;
        fOffsetX = -1f;
        fOffsetZ = iRows - 1f;
        for (i = 0; i < iRows; i++) {
            Vector3 pos = new Vector3(fOffsetX, 0f, fOffsetZ - i);

            RowColumnLabel rowcolumnlabel = Instantiate(RowColumnLabelPrefab, pos, Quaternion.identity).GetComponent<RowColumnLabel>();
            rowcolumnlabel.setValue("" + (char)( ((int) 'A') +  i));
        }

        fOffsetX = 0f;
        fOffsetZ = iRows;
        for (j = 0; j < iCols; j++) {
            Vector3 pos = new Vector3(fOffsetX + j, 0f, fOffsetZ);

            RowColumnLabel rowcolumnlabel = Instantiate(RowColumnLabelPrefab, pos, Quaternion.identity).GetComponent<RowColumnLabel>();
            rowcolumnlabel.setValue("" + (char) (((int) '1') + j));
        }


    }



    void Update() {
        
    }
}
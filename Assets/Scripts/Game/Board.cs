//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

    public GameObject CellPrefab;
    public GameObject RowColumnLabelPrefab;
    public GameObject RescuePrefab;

    public int iRows, iCols;

    public GameManager gamemanager;
    List<RowColumnLabel> rowLabels;
    List<RowColumnLabel> colLabels;
    List<Cell> cells;
    List<Rescue> rescues;

    void Start() {
        
    }

    public void setupBoard() {
        iRows = 5;
        iCols = 5;
        setupCells();
        setupRescue();

    }


    private void setupCells() {

        float fOffsetX;
        float fOffsetZ;
        fOffsetX = -1f;
        fOffsetZ = iRows - 1f;

        cells = new List<Cell>();

        int i, j;
        for (i = 0; i < iRows; i++) {
            for (j = 0; j < iCols; j++) {
                Vector3 pos = new Vector3(j, 0f, fOffsetZ - i);

                Cell cell = Instantiate(CellPrefab, pos, Quaternion.identity).GetComponent<Cell>();
                cell.iRow = i;
                cell.iCol = j;

                cell.transform.SetParent(this.transform);
                cells.Add(cell);
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

        int iRand;
        iRand = Random.Range(0, 9);

        for (i = 0; i < iRows; i++) {
            Vector3 pos = new Vector3(fOffsetX, 0f, fOffsetZ - i);

            RowColumnLabel rowcolumnlabel = Instantiate(RowColumnLabelPrefab, pos, Quaternion.identity).GetComponent<RowColumnLabel>();

            int iCh;
            iCh = (((int)'0') + i) + iRand;
            if (iCh > (int)'9') {
                iCh -= 10;
            }

            char ch = (char)iCh;


            //            char ch = (char)(((int)'1') + i);
            rowcolumnlabel.setValue("" + ch, gamemanager.sequencemanager.getCode(ch));
            rowLabels.Add(rowcolumnlabel);
        }

        fOffsetX = 0f;
        fOffsetZ = iRows;
        iRand = Random.RandomRange(0, 25);

        for (j = 0; j < iCols; j++) {
            Vector3 pos = new Vector3(fOffsetX + j, 0f, fOffsetZ);

            RowColumnLabel rowcolumnlabel = Instantiate(RowColumnLabelPrefab, pos, Quaternion.identity).GetComponent<RowColumnLabel>();
            int iCh;
            iCh = (((int)'A') + j) + iRand;
            if (iCh > (int) 'Z') {
                iCh -= 26;
            }

            char ch = (char) iCh;



            rowcolumnlabel.setValue("" + ch, gamemanager.sequencemanager.getCode(ch));
            colLabels.Add(rowcolumnlabel);
        }


    }

    private void setupRescue() {
        int iRescueCount = 2;

        rescues = new List<Rescue>();

        int i;
        int iRandRow, iRandCol;

        List<Cell> cellsAvailable = new List<Cell>();
        foreach (Cell cell in cells) {
            cellsAvailable.Add(cell);
        }

        for (i = 0; i < iRescueCount; i++) {
            if (cellsAvailable.Count > 0) {
                Cell randCell = cellsAvailable[Random.Range(0, cellsAvailable.Count)];
                Rescue rescue = Instantiate(RescuePrefab, new Vector3(randCell.transform.position.x, 0f, randCell.transform.position.z), Quaternion.identity).GetComponent<Rescue>();
                rescues.Add(rescue);
            }
        }



            /*
            for (i = 0; i < iRescueCount; i++) {
                iRandRow = Random.Range(0, iRows);
                iRandCol = Random.Range(0, iCols);
                Rescue rescue = Instantiate(RescuePrefab, new Vector3(iRandRow, 0f, iRandCol), Quaternion.identity).GetComponent<Rescue>();
                rescues.Add(rescue);
            }
            */
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

        checkStartRescue();
    }

    private void checkStartRescue() {
        //RowColumnLabel rowSelected = null;
        //RowColumnLabel colSelected = null;
        int i;
        int iSelectedRow = -1;
        int iSelectedCol = -1;

        i = 0;
        foreach (RowColumnLabel rowLabel in rowLabels) {
            if (rowLabel.isSelected) {
                //rowSelected = rowLabel;
                iSelectedRow = i;
            }
            i++;
        }

        i = 0;
        foreach (RowColumnLabel colLabel in colLabels) {
            if (colLabel.isSelected) {
                // colSelected = colLabel;
                iSelectedCol = i;
            }
            i++;
        }

        Cell selectedCell;
        selectedCell = getCell(iSelectedRow, iSelectedCol);
        if (selectedCell != null) {
            gamemanager.heli.startRescue(selectedCell);
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

    public Cell getCell(int in_iRow, int in_iCol) {
        Cell cellReturn = null;
        foreach (Cell cell in cells) {
            if (cell.iRow == in_iRow && cell.iCol == in_iCol) {
                cellReturn = cell;
            }
        }

        return cellReturn;
    }

    public Rescue getRescue(Cell in_Cell) {
        Rescue rescueReturn = null;

        if (in_Cell != null) {
            Debug.Log("resuces: " + rescues.Count);
            foreach (Rescue rescue in rescues) {
                if (rescue.transform.position.x == in_Cell.transform.position.x &&
                    rescue.transform.position.z == in_Cell.transform.position.z) {
                    rescueReturn = rescue;
                }
            }
        }

        return rescueReturn;
    }

    /*
    public Cell getRescueCell(Rescue in_Rescue) {
        Cell cellReturn = null;
        int iRow = in_Rescue.transform.position.z;
        int iCol

        return cellReturn;
    }
    */

    public void checkLevelComplete() {
        if (getRescueRemainCount() <= 0) {
            gamemanager.doLevelComplete();
        }
    }

    public int getRescueRemainCount() {
        int iCount = 0;

        foreach (Rescue resuce in rescues) {
            if (!resuce.isRescued) {
                iCount++;
            }
        }

        return iCount;
    }

    public void resetSelectedRowCol() {
        foreach (RowColumnLabel label in rowLabels) {
            label.setSelected(false);
        }

        foreach (RowColumnLabel label in colLabels) {
            label.setSelected(false);
        }

    }
}
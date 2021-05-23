//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceManager : MonoBehaviour {

    List<Sequence> sequences;

    void Start() {
        setupSequences();
        
    }

    void Update() {
        
    }

    private void setupSequences() {
        sequences = new List<Sequence>();

        List<int> iSequence;
        char chLetter;
        Sequence sequence;


        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(1);
        chLetter = 'A';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        chLetter = 'B';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(0);
        iSequence.Add(1);
        iSequence.Add(0);
        chLetter = 'C';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(0);
        iSequence.Add(0);
        chLetter = 'D';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        chLetter = 'E';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(1);
        iSequence.Add(0);
        chLetter = 'F';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(0);
        chLetter = 'G';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        chLetter = 'H';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(0);
        chLetter = 'I';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(1);
        chLetter = 'J';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(0);
        iSequence.Add(1);
        chLetter = 'K';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(1);
        iSequence.Add(0);
        iSequence.Add(0);
        chLetter = 'L';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(1);
        chLetter = 'M';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(0);
        chLetter = 'N';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(1);
        chLetter = 'O';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(0);
        chLetter = 'P';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(0);
        iSequence.Add(1);
        chLetter = 'Q';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(1);
        iSequence.Add(0);
        chLetter = 'R';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        chLetter = 'S';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        chLetter = 'T';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(1);
        chLetter = 'U';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(1);
        chLetter = 'V';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(1);
        iSequence.Add(1);
        chLetter = 'W';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(1);
        chLetter = 'X';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(0);
        iSequence.Add(1);
        iSequence.Add(1);
        chLetter = 'Y';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(0);
        iSequence.Add(0);
        chLetter = 'Z';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(1);
        chLetter = '1';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(1);
        chLetter = '2';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(1);
        iSequence.Add(1);
        chLetter = '3';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(1);
        chLetter = '4';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        chLetter = '5';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        chLetter = '6';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(0);
        iSequence.Add(0);
        iSequence.Add(0);
        chLetter = '7';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(0);
        iSequence.Add(0);
        chLetter = '8';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(0);
        chLetter = '9';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);

        iSequence = new List<int>();
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(1);
        iSequence.Add(1);
        chLetter = '0';
        sequence = new Sequence(iSequence, chLetter);
        sequences.Add(sequence);


    }


    public char getValue(List<int> in_iSequence) {
        char chValue = '?';

        foreach (Sequence sequence in sequences) {
            if (sequence.match(in_iSequence)) {
                chValue = sequence.getLetter();
            }
        }

        return chValue;
    }

    public string getCode(char ch) {
        string strCode = "?";

        foreach (Sequence sequence in sequences) {
            if (sequence.getLetter() == ch) {
                strCode = "";
                foreach(int iValue in sequence.getSequence()) {
                    if (iValue == 0) {
                        strCode += ".";
                    } else if (iValue == 1) {
                        strCode += "-";
                    }
                }
            }
        }


        return strCode;

    }

}
//2021 Levi D. Smith
using System.Collections;
using System.Collections.Generic;

public class Sequence{
    List<int> iSequence;
    char chLetter;

    public Sequence(List<int> in_iSequence, char in_chLetter) {
        iSequence = in_iSequence;
        chLetter = in_chLetter;

    }

    public bool match(List<int> in_iSequence) {
        bool isMatch = false;

        if (in_iSequence.Count == iSequence.Count) {
            isMatch = true;
            int i;
            for (i = 0; i < iSequence.Count; i++) {
                if (in_iSequence[i] != iSequence[i]) {
                    isMatch = false;
                }
            }

        }

        return isMatch;
    }

    public char getLetter() {
        return chLetter;
    }


}
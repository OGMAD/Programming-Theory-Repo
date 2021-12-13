using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;

    // ENCAPSULATION
    public static int GetScore()
    {
        return score;
    }

    // ENCAPSULATION
    public static void SetScore(int scoreToSet)
    {
        score = scoreToSet;
    }

}

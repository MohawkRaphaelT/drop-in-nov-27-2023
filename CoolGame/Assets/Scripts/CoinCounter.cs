using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private int score;

    public void AddToScore(int points)
    {
        score += points;
        Debug.Log(score);
    }
}

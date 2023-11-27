using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public TMP_Text scoreDisplay;
    private int score;

    public void Start()
    {
        DisplayScore();
    }

    public void AddToScore(int points)
    {
        score += points;
        DisplayScore();
    }

    public void DisplayScore()
    {
        scoreDisplay.text = $"Score: {score:00000000}";
    }
}

using UnityEngine;

public class CoinCounterTrigger : MonoBehaviour
{
    public CoinCounter coinCounter;
    public int pointsToAdd = 1;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        coinCounter.AddToScore(pointsToAdd);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;

    void Start()
    {
        
    }

    void Update()
    {
        bool doDropCoin = Input.GetKeyDown(KeyCode.Space);

        if (doDropCoin)
        {
            Vector3 position = transform.position;
            GameObject gobj = Instantiate(coin, position, Quaternion.identity);
            gobj.SetActive(true);
        }
    }
}

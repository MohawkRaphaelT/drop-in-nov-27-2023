using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 movement = new Vector3();

        bool isHoldingLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isHoldingRight = Input.GetKey(KeyCode.RightArrow);

        if (isHoldingLeft)
            movement.x -= speed;

        if (isHoldingRight)
            movement.x += speed;

        transform.position += movement * Time.deltaTime;
    }
}

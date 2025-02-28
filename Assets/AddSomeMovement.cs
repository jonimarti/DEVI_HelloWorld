using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSomeMovement : MonoBehaviour
{
    bool isGoingUp = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkMovement();
        checkScale();
        //UpAndDownAnimation();
        //checkRotation();
    }

    private void checkRotation()
    {
        transform.rotation *= Quaternion.Euler(0, 1, 0);
 
        
      //  transform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);

    }
    private void UpAndDownAnimation()
    {
        ShouldGoUp();
        ShouldGoDown();
    }
    private void ShouldGoDown()
    {
        while (!isGoingUp && transform.position.x > 0)
        {
            transform.position += Vector3.down;
            if (transform.position.x <= 0)
            {
                isGoingUp = true;
            }
        }
    }
    private void ShouldGoUp()
    {
        while (isGoingUp && transform.position.x < 8)
        {
            transform.position += Vector3.up;
            if (transform.position.x >= 8)
            {
                isGoingUp = false;
            }
        }
    }
    private void checkScale()
    {
        if (Input.GetKeyDown(KeyCode.Z))  
        {
            transform.localScale += Time.deltaTime * Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.localScale += Vector3.back;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            transform.localScale += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            transform.localScale += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            transform.localScale += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            transform.localScale += Vector3.down;
        }
    }
    private void checkMovement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position +=  Vector3.back;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position +=  Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position +=  Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position +=  Vector3.down;
        }
    }
}

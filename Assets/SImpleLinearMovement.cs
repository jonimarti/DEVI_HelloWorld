using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SImpleLinearMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		CheckIfShouldMove();

	}

	private void CheckIfShouldMove()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
			transform.position += Vector3.forward;
	}
}

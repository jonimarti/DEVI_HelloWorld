using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTracker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TrackedObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		PositionLogTrace();

	}



	private void PositionLogTrace()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log("Object: " + TrackedObject.name + " position X is:" + TrackedObject.transform.position.x +
												   " position Y is:" + TrackedObject.transform.position.y +
												   " position Z is:" + TrackedObject.transform.position.z);
		}
	}
}

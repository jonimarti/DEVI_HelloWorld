using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
	{
		CapsuleSpawner();

	}

	private static void CapsuleSpawner()
	{
		float offset = 2;
		int maxNumberOfObjects = 100;
	

		for (int i = 0; i < maxNumberOfObjects; i++)
		{
			GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			capsule.AddComponent<PositionTracker>().TrackedObject = capsule;
			capsule.transform.position = new Vector3(i * offset, i * offset, 0);
		}
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}

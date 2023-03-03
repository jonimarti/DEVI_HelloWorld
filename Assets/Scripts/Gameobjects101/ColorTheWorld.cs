using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorTheWorld : MonoBehaviour
{
    // Start is called before the first frame update
    Object[] allTheGameObjects;
    [Serialize]
    public Color color;
    [Serialize]
    public bool findByTag;
    [Serialize]
    public string choosenTag;
    void Start()
    {
        
		if (findByTag)
        {
            allTheGameObjects = GameObject.FindGameObjectsWithTag(choosenTag);
        }                             
		else
        {
            allTheGameObjects = GameObject.FindObjectsOfType(typeof(MonoBehaviour));

        }
    }
 

    // Update is called once per frame
    void Update()
    {
		foreach (var item in allTheGameObjects)
		{
        if(item.GetComponent<MeshRenderer>())
         item.GetComponent<MeshRenderer>().material.color = color;
        }

        
        //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}

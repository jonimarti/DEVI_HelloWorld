using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMe : MonoBehaviour
{
    public Color myColor = Color.blue;
    private Color LastColorUsed = Color.blue;
    MeshRenderer MyMaterial;
    // Start is called before the first frame update
    void Start()
    {
        MyMaterial = gameObject.GetComponent<MeshRenderer>();
      
    }

    // Update is called once per frame
    void Update()
    {
            MyMaterial.material.color = myColor;
        
        
        
    }
}

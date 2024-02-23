using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HelloWorld : MonoBehaviour
{
    Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
 
        enemy = new Enemy(" Voldemort");
        Player player = new Player(" HP");
    }

    // Update is called once per frame
    void Update()
    {


    }


}

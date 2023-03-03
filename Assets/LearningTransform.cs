using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningTransform : MonoBehaviour
{
    Transform MyTransform;
    // Start is called before the first frame update
    void Start()
    {
        MyTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        LogPosition();
        LogRotation();
        LogScale();

    }

    private void LogScale()
    {
        Debug.Log("La rotacion del Cubo en x" + this.transform.localScale.x);
        Debug.Log("La rotacion del Cubo en y" + this.transform.localScale.y);
        Debug.Log("La rotacion del Cubo en z" + this.transform.localScale.z);
    }

    private void LogRotation()
    {
        Debug.Log("La rotacion del Cubo en x" + this.transform.localRotation.x);
        Debug.Log("La rotacion del Cubo en x" + this.transform.localRotation.y);
        Debug.Log("La rotacion del Cubo en z" + this.transform.localRotation.z);
    }

    private void LogPosition()
    {
        Debug.Log("La posición del Cubo en x" + this.transform.position.x);
        Debug.Log("La posición del Cubo en y" + this.GetComponent<Transform>().rotation.y);
        Debug.Log("La posición del Cubo en z" + MyTransform.position.z);
    }
}

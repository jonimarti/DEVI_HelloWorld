using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIntro
{
    public class MoveBehaviour : MonoBehaviour
    {

        [SerializeField]
        private float moveSpeed = 4;
        [SerializeField]
        private float rotateSpeed = 4;

        [SerializeField]
        private Transform sun;
        [SerializeField]
        private Transform earth;
        [SerializeField]
        private Transform moon;

        void Start()
        {
            //transform.position = new Vector3(0, 2, 0);

            Debug.Log(transform.childCount);

            // SetParent cambia el padre a un objeto de la jerarquía.
            // Hacer que moon sea hijo de earth.
            moon.SetParent(earth);
            // Hacer que earth sea hijo de sun.
            earth.SetParent(sun);

            Debug.Log(transform.childCount);

        }

        private void Update()
        {
            // Mover un objeto usando el transform

            //transform.position += transform.forward * Time.deltaTime * moveSpeed;
            //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

            // Rotar un objeto usando el transform

            //transform.rotation *= Quaternion.Euler(Vector3.up * rotateSpeed * Time.deltaTime) ;
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);

            // Cambiar la escala de un objeto

            transform.localScale = Vector3.one * .5f;
        }

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIntro
{

    public class SampleBehaviour : MonoBehaviour
    {
        private GameObject createdGameObject;

        /*
         * El valor de las variables públicas se puede establecer en el editor de Unity (en el inspector).
         * Con el atributo SerializeField se pueden establecer también el valor de las privadas.
         */
        [SerializeField]
        private GameObject player;

        /*
         * Space: deja un espacio en el inspector
         * Header: permite poner etiquetas en el inspector
         */
        [Space]
        [Header("Primitives")]

        [SerializeField]
        [Range(0, 140)]
        private int integer = 1;
        [SerializeField]
        private float floatNumber;
        [SerializeField]
        private string name;

        [Header("Colors")]

        [SerializeField]
        private Color playerColor;
        [SerializeField]
        private Color defaultColor;

        private void Awake()
        {
            // Creación de GameObject nuevo. Al crearlo aparece en la raíz de la escena activa.
            createdGameObject = new GameObject("Ejemplo");

            // Añadir Componentes a un GameObject
            createdGameObject.AddComponent<MoveBehaviour>();

            // Obtene un Componente de un GameObject
            var move = createdGameObject.GetComponent<MoveBehaviour>();

            // Destroy: permite destruir GameObjects o componentes
            Destroy(move);

            // Encontrar GameObject por nombre
            var cube = GameObject.Find("Cube");
            var cubeRenderer = cube.GetComponent<Renderer>();

            // Cambiar el color de un material
            cubeRenderer.material.color = defaultColor;

            // Encontrar GameObject por sus componentes
            var renderers = GameObject.FindObjectsOfType<Renderer>();
            foreach (var renderer in renderers)
            {
                renderer.material.color = defaultColor;
            }

            // Encontrar GameObject por tag
            //var player = GameObject.FindGameObjectWithTag("Player");

            player.GetComponent<Renderer>().material.color = playerColor;
        }

        private void Update()
        {
            // Pregunar si una tecla ha sido pulsada
            if (Input.GetKeyDown(KeyCode.Delete))
            {
                Destroy(createdGameObject);
            }

            player.GetComponent<Renderer>().material.color = playerColor;
        }

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    private Rigidbody playerRigidbody;

    [SerializeField]
    private float force;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Si acabamos de pulsar la tecla espacio...
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Añadir una fuerza a la esfera
            playerRigidbody.AddForce(transform.forward * force);
        }
    }
}

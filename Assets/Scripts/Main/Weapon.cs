using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float chaseSpeed;

    void Update()
    {
        // Hacer que un objeto se oriente y mire a otro
        transform.LookAt(target);

        // Calcular una dirección de movimiento desde el transfrom propio hacía el de target
        Vector3 direction = target.position - transform.position;

        // Mover el transform propio hacía target
        transform.position += direction.normalized * chaseSpeed * Time.deltaTime;
    }
}

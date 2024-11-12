using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    public Transform target; // El personaje
    public Vector3 offset = new Vector3(0, 5, -10); // Ajuste de la posici�n de la c�mara

    void LateUpdate()
    {
        // Actualiza la posici�n de la c�mara para seguir al personaje
        transform.position = target.position + offset;
    }
}

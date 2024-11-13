using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float spinSpeed = 500f;
   
    // Update is called once per frame
    void Update()
    {
        // Hacer girar la hélice alrededor del eje Z
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
    }
}

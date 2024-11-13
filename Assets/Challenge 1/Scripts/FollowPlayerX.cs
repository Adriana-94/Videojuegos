﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // Ajusta el offset de la cámara
        offset = new Vector3(0, 5, -10);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (plane != null)
        {
            transform.position = plane.transform.position + offset;
            transform.LookAt(plane.transform);
        }

    }
}
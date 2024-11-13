using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoCarro
{
    public class CarController : MonoBehaviour
    {
        public float speed = 20f;
        public float turnSpeed = 100f;

     
        // Start is called before the first frame update
        void Start()
        {
            

        }

        // Update is called once per frame
        void Update()
        {
            float verticalImput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * Time.deltaTime * verticalImput *speed);

            //Rotate
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * turnSpeed);
        }

       
    }

}


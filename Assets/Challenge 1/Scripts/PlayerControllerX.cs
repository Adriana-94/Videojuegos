using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Proyecto.Avion
{
    public class PlayerControllerX : MonoBehaviour
    {
        public float speed = 5.0f;
        public float rotationSpeed = 100.0f;
        public float verticalInput;
        public float horizontalInput;
        public float maxTiltAngle = 45.0f;


        private Rigidbody rb;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update se usa para manejar la física del avión
        void Update()
        {
            // Obtener la entrada vertical y horizontal del jugador
            verticalInput = Input.GetAxis("Vertical");
            horizontalInput = Input.GetAxis("Horizontal");

            // Mover el avión hacia adelante a una velocidad reducida
            transform.Translate(0, 0, horizontalInput * speed * Time.deltaTime);


            // Inclinar el avión hacia arriba/abajo basado en las teclas de flechas o W/S

            if (verticalInput != 0)
            {
                float tilt = rotationSpeed * verticalInput * Time.deltaTime;
                transform.Rotate(Vector3.right * tilt);
            }

        }
    }

}

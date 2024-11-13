using UnityEngine;

public class GroundMover : MonoBehaviour
{
    public float speed = 5f;         // Velocidad a la que se mueve el suelo
    public float resetPosition = -50f; // Posición en Z para reiniciar el suelo
    public float startPosition = 50f;  // Posición inicial en Z para el reinicio

    void Update()
    {
        // Mueve el suelo hacia atrás
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        // Verifica si el suelo ha llegado al límite para reiniciar su posición
        if (transform.position.z <= resetPosition)
        {
            // Reinicia la posición del suelo
            transform.position = new Vector3(transform.position.x, transform.position.y, startPosition);
        }
    }
}


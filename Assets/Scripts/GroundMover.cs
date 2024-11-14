using UnityEngine;

public class GroundMover : MonoBehaviour
{
    public float speed = 5f;         // Velocidad a la que se mueve el suelo
    public float resetPosition = -100f; // Posici�n en Z para reiniciar el suelo
    public float startPosition = -6f;  // Posici�n inicial en Z para el reinicio

    void Update()
    {
        // Mueve el suelo hacia atr�s
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        // Verifica si el suelo ha llegado al l�mite para reiniciar su posici�n
        if (transform.position.z <= resetPosition)
        {
            // Reinicia la posici�n del suelo
            transform.position = new Vector3(transform.position.x, transform.position.y, startPosition);
        }
    }
}


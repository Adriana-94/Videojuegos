using UnityEngine;

public class BeeController : MonoBehaviour
{
    
    public float dodgeSpeed = 3f; // Velocidad de movimiento lateral
    public float dodgeRange = 2f; // Rango de movimiento lateral

    private float initialZ; // Posición inicial en Z para limitar el rango

    void Start()
    {
        initialZ = transform.position.z;
    }

    void Update()
    {
        // Movimiento lateral con límite de rango
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 newPosition = transform.position + Vector3.right * horizontalInput * dodgeSpeed * Time.deltaTime;
        newPosition.z = Mathf.Clamp(newPosition.z, initialZ - dodgeRange, initialZ + dodgeRange);
        transform.position = newPosition;
    }


}


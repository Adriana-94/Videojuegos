using UnityEngine;

public class BeeController : MonoBehaviour
{
    public float dodgeSpeed = 3f;
    public float dodgeRange = 2f;
    public float verticalSpeed = 3f;
    public float verticalRange = 2f;

    private float initialZ;
    private float initialY;
    public float minY = 0.5f;  // Límite en Y para no atravesar el suelo

    void Start()
    {
        initialZ = transform.position.z;
        initialY = transform.position.y;
    }

    void Update()
    {
        // Movimiento lateral
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 newPosition = transform.position + Vector3.right * horizontalInput * dodgeSpeed * Time.deltaTime;

        // Movimiento vertical
        float verticalInput = Input.GetAxis("Vertical");
        newPosition.y += verticalInput * verticalSpeed * Time.deltaTime;

        // Limitar el movimiento en Z
        newPosition.z = Mathf.Clamp(newPosition.z, initialZ - dodgeRange, initialZ + dodgeRange);

        // Limitar el movimiento en Y
        newPosition.y = Mathf.Clamp(newPosition.y, minY, initialY + verticalRange);

        // Aplicar la nueva posición
        transform.position = newPosition;

        // Asegurarse de que no atraviese el suelo
        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, transform.position.z);
        }
    }
}

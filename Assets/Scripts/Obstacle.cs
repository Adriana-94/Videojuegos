using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed = 2f;

    void Update()
    {
        // Movimiento hacia la abeja
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bee"))
        {
            GameManager.instance.GameOver();
            
            Destroy(gameObject);
            Debug.Log("El objeto se destruye");
        }
    }
}

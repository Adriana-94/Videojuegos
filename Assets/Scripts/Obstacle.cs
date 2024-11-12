using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject explosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bee"))
        {
            if (explosionEffect != null)
            {
                Instantiate(explosionEffect, transform.position, transform.rotation);
            }
            Debug.Log("colisiona");
            Destroy(gameObject); // Destruye el obstáculo al colisionar con la abeja
        }
    }
}

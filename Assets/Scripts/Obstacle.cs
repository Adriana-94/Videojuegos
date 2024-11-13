using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject explosionEffect;

    private void Update()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bee"))
        {
            Debug.Log("Colisión con la abeja detectada");
            // Genera el efecto de explosión si está asignado
            if (explosionEffect != null)
            {
                Instantiate(explosionEffect, transform.position, transform.rotation);
            }

            // Llama a GameOver en GameManager y destruye el obstáculo
            GameManager.instance.GameOver();
            Destroy(gameObject);
        }
    }
}

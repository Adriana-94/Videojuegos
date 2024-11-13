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
            Debug.Log("Colisi�n con la abeja detectada");
            // Genera el efecto de explosi�n si est� asignado
            if (explosionEffect != null)
            {
                Instantiate(explosionEffect, transform.position, transform.rotation);
            }

            // Llama a GameOver en GameManager y destruye el obst�culo
            GameManager.instance.GameOver();
            Destroy(gameObject);
        }
    }
}

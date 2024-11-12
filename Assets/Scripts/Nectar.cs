using UnityEngine;

public class Nectar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bee"))
        {
            // Incrementar el puntaje o la cantidad de néctar recogido
            GameManager.instance.AddNectar();
            Destroy(gameObject); // Destruir el objeto de néctar
        }
    }
}

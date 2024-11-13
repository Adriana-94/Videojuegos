using UnityEngine;

public class Nectar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bee"))
        {
            GameManager.instance.AddNectar();
            Destroy(gameObject);
        }
    }
}


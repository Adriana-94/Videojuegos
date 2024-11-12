using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int nectarCollected = 0;

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void AddNectar()
    {
        nectarCollected++;
        Debug.Log("Néctar recolectado: " + nectarCollected);
        // Aquí puedes incrementar la dificultad o añadir otros efectos
    }

    public void GameOver()
    {
        Debug.Log("¡Juego terminado!");
        // Aquí puedes detener el movimiento de la abeja y mostrar un mensaje de fin
    }

}


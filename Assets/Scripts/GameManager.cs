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
        Debug.Log("N�ctar recolectado: " + nectarCollected);
        // Aqu� puedes incrementar la dificultad o a�adir otros efectos
    }

    public void GameOver()
    {
        Debug.Log("�Juego terminado!");
        // Aqu� puedes detener el movimiento de la abeja y mostrar un mensaje de fin
    }

}


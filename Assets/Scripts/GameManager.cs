using TMPro;
using UnityEngine;
using UnityEngine.UI; // Necesario para usar UI en Unity

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int nectarCollected = 0;
    public int maxNectar = 30; // Valor máximo para llenar la barra de néctar
    public Slider nectarBar; // Barra de progreso para el néctar

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        if (nectarBar != null)
        {
            nectarBar.maxValue = maxNectar; // Configura el valor máximo de la barra
            nectarBar.value = nectarCollected; // Inicializa la barra en cero
        }
    }

    public void AddNectar()
    {
        nectarCollected += 5; // Incrementa el puntaje por cada néctar (puedes cambiar el valor)

        UpdateNectarBarUI(); // Actualiza la barra de progreso

        if (nectarCollected >= maxNectar)
        {
            GameOver();
        }
    }

    void UpdateNectarBarUI()
    {
        if (nectarBar != null)
        {
            nectarBar.value = nectarCollected; // Actualiza el valor de la barra con el néctar recolectado
        }
    }

    public void GameOver()
    {
        Debug.Log("¡Game Over!"); // Aquí puedes detener el movimiento de la abeja y mostrar un mensaje de fin
        Time.timeScale = 0f; // Detiene el juego
    }
}

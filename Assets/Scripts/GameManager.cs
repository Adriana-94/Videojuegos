using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int nectarCollected = 0;
    public int initialMaxNectar = 10; // Puntaje necesario para el primer llenado de la barra
    private int currentMaxNectar;
    public Slider nectarBar; // Barra de progreso para el néctar

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        currentMaxNectar = initialMaxNectar; // Inicializa el valor máximo con el primer objetivo
        if (nectarBar != null)
        {
            nectarBar.maxValue = currentMaxNectar; // Configura el valor máximo de la barra
            nectarBar.value = nectarCollected; // Inicializa la barra en cero
        }
    }

    public void AddNectar()
    {
        nectarCollected += 5; // Incrementa el puntaje por cada néctar (puedes cambiar el valor)

        UpdateNectarBarUI(); // Actualiza la barra de progreso

        if (nectarCollected >= currentMaxNectar)
        {
            ResetNectar(); // Reinicia el progreso de la barra de néctar con un nuevo objetivo
        }
    }

    void UpdateNectarBarUI()
    {
        if (nectarBar != null)
        {
            nectarBar.value = nectarCollected; // Actualiza el valor de la barra con el néctar recolectado
        }
    }

    void ResetNectar()
    {
        Debug.Log("¡Barra de néctar llena! Reiniciando con un nuevo objetivo...");

        // Duplica el valor de maxNectar y reinicia el néctar recolectado
        nectarCollected = 0;
        currentMaxNectar *= 2;

        // Actualiza la barra con el nuevo valor máximo
        if (nectarBar != null)
        {
            nectarBar.maxValue = currentMaxNectar;
            nectarBar.value = nectarCollected;
        }
    }

    public void GameOver()
    {
        Debug.Log("¡Game Over!");
        Time.timeScale = 0f; // Detiene el juego
    }
}

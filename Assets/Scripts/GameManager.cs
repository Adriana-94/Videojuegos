using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int nectarCollected = 0;
    public int initialMaxNectar = 10; // Puntaje necesario para el primer llenado de la barra
    private int currentMaxNectar;
    public Slider nectarBar; // Barra de progreso para el n�ctar

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        currentMaxNectar = initialMaxNectar; // Inicializa el valor m�ximo con el primer objetivo
        if (nectarBar != null)
        {
            nectarBar.maxValue = currentMaxNectar; // Configura el valor m�ximo de la barra
            nectarBar.value = nectarCollected; // Inicializa la barra en cero
        }
    }

    public void AddNectar()
    {
        nectarCollected += 5; // Incrementa el puntaje por cada n�ctar (puedes cambiar el valor)

        UpdateNectarBarUI(); // Actualiza la barra de progreso

        if (nectarCollected >= currentMaxNectar)
        {
            ResetNectar(); // Reinicia el progreso de la barra de n�ctar con un nuevo objetivo
        }
    }

    void UpdateNectarBarUI()
    {
        if (nectarBar != null)
        {
            nectarBar.value = nectarCollected; // Actualiza el valor de la barra con el n�ctar recolectado
        }
    }

    void ResetNectar()
    {
        Debug.Log("�Barra de n�ctar llena! Reiniciando con un nuevo objetivo...");

        // Duplica el valor de maxNectar y reinicia el n�ctar recolectado
        nectarCollected = 0;
        currentMaxNectar *= 2;

        // Actualiza la barra con el nuevo valor m�ximo
        if (nectarBar != null)
        {
            nectarBar.maxValue = currentMaxNectar;
            nectarBar.value = nectarCollected;
        }
    }

    public void GameOver()
    {
        Debug.Log("�Game Over!");
        Time.timeScale = 0f; // Detiene el juego
    }
}

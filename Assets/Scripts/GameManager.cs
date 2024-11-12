using TMPro;
using UnityEngine;
using UnityEngine.UI; // Necesario para usar UI en Unity

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int nectarCollected = 0;

    public TextMeshProUGUI scoreText; // Referencia al texto de puntaje en la UI

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void AddNectar()
    {
        nectarCollected += 1; // Incrementa el puntaje por cada n�ctar (puedes cambiar el valor)
        UpdateScoreUI(); // Actualiza la UI
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Puntaje: " + nectarCollected;
        }
    }

    public void GameOver()
    {
        Debug.Log("�Juego terminado!");
        // Aqu� puedes detener el movimiento de la abeja y mostrar un mensaje de fin
    }
}

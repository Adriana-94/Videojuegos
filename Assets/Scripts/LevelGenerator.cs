using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] nectarPrefab;
    public GameObject[] obstaclePrefab;

    public Vector3 spawnArea = new Vector3(10, 4, 30); // Área de generación
    public float nectarStartDelay = 2.0f; // Intervalo para generar néctar
    public float nectarRepeatRate = 2.0f;
    public float obstacleStartDelay = 2.0f; // Intervalo para generar obstáculos
    public float obstacleRepeatRate = 2.0f;

    public Transform groundTransform; // Suelo en el que se generarán los objetos
    public float objectLifetime = 8.0f; // Tiempo de vida para objetos generados
    public float objectHeight = 4.0f; // Altura inicial para los objetos (igual a la altura de la abeja)

    void Start()
    {
        InvokeRepeating("GenerateNectar", nectarStartDelay, nectarRepeatRate); // Genera néctar indefinidamente
        InvokeRepeating("GenerateObstacle", obstacleStartDelay, obstacleRepeatRate); // Genera obstáculos indefinidamente
    }

    void GenerateNectar()
    {
        int nectarIndex = Random.Range(0, nectarPrefab.Length);

        Vector3 randomPosition = GetRandomSpawnPosition();
        GameObject nectar = Instantiate(nectarPrefab[nectarIndex], randomPosition, Quaternion.identity);
        nectar.transform.parent = groundTransform; // Ancla el néctar al suelo
        Destroy(nectar, objectLifetime); // Destruir néctar después de un tiempo
    }

    void GenerateObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefab.Length);

        Vector3 randomPosition = GetRandomSpawnPosition();
        GameObject obstacle = Instantiate(obstaclePrefab[obstacleIndex], randomPosition, Quaternion.identity);
        obstacle.transform.parent = groundTransform; // Ancla el obstáculo al suelo
        Destroy(obstacle, objectLifetime); // Destruir obstáculo después de un tiempo
    }

    // Función para obtener una posición aleatoria en el área de generación con altura fija
    private Vector3 GetRandomSpawnPosition()
    {
        return new Vector3(
            Random.Range(-spawnArea.x, spawnArea.x),
            objectHeight, // Fijar la altura a la de la abeja
            Random.Range(0, spawnArea.z)
        );
    }
}

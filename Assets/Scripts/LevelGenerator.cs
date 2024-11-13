using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject nectarPrefab;
    public GameObject obstaclePrefab;
    public Transform groundTransform; // Suelo en el que se generar�n los objetos

    public Vector3 spawnArea = new Vector3(10, 1, 50); // �rea de generaci�n
    public float nectarSpawnInterval = 2f;  // Intervalo para generar n�ctar
    public float obstacleSpawnInterval = 3f; // Intervalo para generar obst�culos

    void Start()
    {
        InvokeRepeating("GenerateNectar", 0f, nectarSpawnInterval); // Genera n�ctar indefinidamente
        InvokeRepeating("GenerateObstacle", 1f, obstacleSpawnInterval); // Genera obst�culos indefinidamente
    }

    void GenerateNectar()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(-spawnArea.x, spawnArea.x),
            1f,
            Random.Range(0, spawnArea.z)
        );

        GameObject nectar = Instantiate(nectarPrefab, randomPosition, Quaternion.identity);
        nectar.transform.parent = groundTransform; // Ancla el n�ctar al suelo
    }

    void GenerateObstacle()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(-spawnArea.x, spawnArea.x),
            0.5f,
            Random.Range(0, spawnArea.z)
        );

        GameObject obstacle = Instantiate(obstaclePrefab, randomPosition, Quaternion.identity);
        obstacle.transform.parent = groundTransform; // Ancla el obst�culo al suelo
    }
}

using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject nectarPrefab;
    public GameObject obstaclePrefab;
    public int nectarCount = 1;
    public int obstacleCount = 5;
    public Vector3 spawnArea = new Vector3(10, 1, 50);
    public Transform groundTransform; // El suelo en el que generaremos los objetos

    void Start()
    {
        GenerateNectar();
        GenerateObstacles();
    }

    void GenerateNectar()
    {
        for (int i = 0; i < nectarCount; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-spawnArea.x, spawnArea.x),
                1f,
                Random.Range(0, spawnArea.z)
            );
            GameObject nectar = Instantiate(nectarPrefab, randomPosition, Quaternion.identity);
            nectar.transform.parent = groundTransform; // Ancla el néctar al suelo
        }
    }

    void GenerateObstacles()
    {
        for (int i = 0; i < obstacleCount; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-spawnArea.x, spawnArea.x),
                1f,
                Random.Range(0, spawnArea.z)
            );
            GameObject obstacle = Instantiate(obstaclePrefab, randomPosition, Quaternion.identity);
            obstacle.transform.parent = groundTransform; // Ancla el obstáculo al suelo
        }
    }
}

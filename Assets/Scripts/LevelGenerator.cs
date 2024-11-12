using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject nectarPrefab;     // Prefab del néctar
    public GameObject obstaclePrefab;   // Prefab del obstáculo
    public int nectarCount = 10;        // Número de objetos de néctar a generar
    public int obstacleCount = 5;       // Número de obstáculos a generar
    public Vector3 spawnArea = new Vector3(10, 1, 50); // Área de generación

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
                1f,  // Altura del néctar
                Random.Range(0, spawnArea.z)
            );
            Instantiate(nectarPrefab, randomPosition, Quaternion.identity);
        }
    }

    void GenerateObstacles()
    {
        for (int i = 0; i < obstacleCount; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-spawnArea.x, spawnArea.x),
                0.5f,  // Altura del obstáculo
                Random.Range(0, spawnArea.z)
            );
            Instantiate(obstaclePrefab, randomPosition, Quaternion.identity);

            
        }

    }


}

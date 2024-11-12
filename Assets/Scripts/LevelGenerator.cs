using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject nectarPrefab;     // Prefab del n�ctar
    public GameObject obstaclePrefab;   // Prefab del obst�culo
    public int nectarCount = 10;        // N�mero de objetos de n�ctar a generar
    public int obstacleCount = 5;       // N�mero de obst�culos a generar
    public Vector3 spawnArea = new Vector3(10, 1, 50); // �rea de generaci�n

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
                1f,  // Altura del n�ctar
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
                0.5f,  // Altura del obst�culo
                Random.Range(0, spawnArea.z)
            );
            Instantiate(obstaclePrefab, randomPosition, Quaternion.identity);

            
        }

    }


}

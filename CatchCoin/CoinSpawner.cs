using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnInterval = 1.2f;
    public float minX = -7f;
    public float maxX = 7f;

    void Start()
    {
        // Munculkan koin berulang secara otomatis
        InvokeRepeating("SpawnCoin", 1f, spawnInterval);
    }

    void SpawnCoin()
    {
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPos = new Vector3(randomX, 5.5f, 0);
        Instantiate(coinPrefab, spawnPos, Quaternion.identity);
    }
}
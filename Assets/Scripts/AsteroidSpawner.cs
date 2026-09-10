using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnInterval = 2f;
    public float spawnRadius = 10f;
    private void Start()
    {
        InvokeRepeating("SpawnAsteroid", 0f, spawnInterval);
    }
    private void SpawnAsteroid()
    {
        Vector3 spawnPosition = Random.insideUnitSphere * spawnRadius;
        spawnPosition.y = 0; // Keep asteroids on the ground level
        Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
    }
}

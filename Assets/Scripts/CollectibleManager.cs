using UnityEngine;

public class CollectibleManager : MonoBehaviour

{
    public GameObject scrapPrefab;
    public int scrapcount = 5;
    public Vector3 spawnArea = new Vector3(40, 0, 40);

    void Start()
    {
        SpawnScrap();
    }

    void SpawnScrap()
    {
        for (int i = 0; i < scrapcount; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-spawnArea.x / 2, spawnArea.x / 2), 0, Random.Range(-spawnArea.z / 2, spawnArea.z / 2));
            Instantiate (scrapPrefab, pos, Quaternion.identity);
        }
    }
}
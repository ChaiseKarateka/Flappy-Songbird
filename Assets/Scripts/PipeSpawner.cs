using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float minY = -1f;
    public float maxY = 3f;

    void Start()
    {
        InvokeRepeating("SpawnPipe", 1f, spawnRate);
    }

    void SpawnPipe()
    {
        float y = Random.Range(minY, maxY);
        Vector3 pos = new Vector3(10, y, 0);
        Instantiate(pipePrefab, pos, Quaternion.identity);
    }
}

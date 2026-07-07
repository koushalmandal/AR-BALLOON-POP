using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    public GameObject balloonPrefab;
    public float spawnInterval = 1f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnBalloon), 1f, spawnInterval);
    }

void SpawnBalloon()
{
    for (int i = 0; i < 3; i++)
    {
        Vector3 pos = new Vector3(
            Random.Range(-2f, 2f),   // Left and right
            -3f,                     // Start from the bottom
            Random.Range(1f, 4f)     // Distance from camera
        );

        Instantiate(balloonPrefab, pos, Quaternion.identity);
    }
}
}
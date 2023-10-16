using UnityEngine;

public class SpawnOne : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject platform;

    void Update()
    {
        Instantiate(platform, new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, 0), Quaternion.identity);
    }
}
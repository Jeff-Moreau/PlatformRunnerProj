using UnityEngine;

public class SpawnOne : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject platform;

    private bool canPlace;

    private void Update()
    {
        if (canPlace)
        {
            Instantiate(platform, new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, 0), Quaternion.identity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canPlace = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        canPlace = true;
    }
}
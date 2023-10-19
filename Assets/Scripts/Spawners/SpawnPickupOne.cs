using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickupOne : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private List<GameObject> pickups;

    private float timeCounter = 0;
    private const float REFRESHTIME = 1;

    void Update()
    {
        timeCounter -= Time.deltaTime;

        if (timeCounter <= 0)
        {
            var newPickup = Random.Range(0, pickups.Count);

            if (pickups[newPickup].name == "JetPackPickup" && !pickups[newPickup].activeInHierarchy)
            {
                Instantiate(pickups[newPickup], new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, 0), Quaternion.identity);
            }
            timeCounter = REFRESHTIME;
        }
    }
}

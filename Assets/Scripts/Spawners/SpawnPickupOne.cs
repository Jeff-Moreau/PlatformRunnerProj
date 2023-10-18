using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickupOne : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private List<GameObject> pickups;

    private float timeCounter = 0;
    private const float REFRESHTIME = 1;

    void Start()
    {
        
    }

    void Update()
    {
        timeCounter -= Time.deltaTime;

        if (timeCounter <= 0)
        {
            Instantiate(pickups[Random.Range(0, pickups.Count)], new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, 0), Quaternion.identity);
            timeCounter = REFRESHTIME;
        }
    }
}

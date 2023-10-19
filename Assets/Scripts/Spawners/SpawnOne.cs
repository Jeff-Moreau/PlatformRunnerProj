using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnOne : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private List<GameObject> platforms;

    private float timeCounter;
    private const float REFRESHTIME = 1;
    private int platformCount;
    private bool spawn;

    private void Start()
    {
        spawn = true;
        platformCount = 0;
        timeCounter = REFRESHTIME;
    }

    private void Update()
    {
        timeCounter -= Time.deltaTime;

        float randPlat = Random.Range(1, 2);

        if (timeCounter <= 0 && spawn)
        {
            Instantiate(platforms[Random.Range(0, platforms.Count)], new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, 0), Quaternion.identity);
            timeCounter = REFRESHTIME;
            platformCount++;
        }


    }
}
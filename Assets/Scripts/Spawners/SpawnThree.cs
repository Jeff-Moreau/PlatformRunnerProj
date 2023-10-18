
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnThree : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private List<GameObject> platforms;

    private float timeCounter;
    private const float REFRESHTIME = 3;
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

        float randPlat = Random.Range(6, 10);

        if (platformCount == randPlat)
        {
            spawn = false;
        }
        else if (timeCounter <= 0 && spawn)
        {
            Instantiate(platforms[Random.Range(0, platforms.Count)], new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, 0), Quaternion.identity);
            timeCounter = REFRESHTIME;
            platformCount++;
        }
        else if (timeCounter <= 0 && !spawn)
        {
        float randTime = Random.Range(3, randPlat*4);
            timeCounter = randTime;
            platformCount = 0;
            spawn = true;
        }

    }
}

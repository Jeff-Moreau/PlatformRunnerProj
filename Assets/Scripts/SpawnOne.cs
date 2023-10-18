using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnOne : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject platform;

    private List<Transform> positions;

    private float timeCounter;
    private const float REFRESHTIME = 1;
    private bool canPlace;
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

        float randPlat = Random.Range(1, 5);
        float randTime = Random.Range(0, randPlat/2);

        if (platformCount == randPlat)
        {
            spawn = false;
        }
        else if (timeCounter <= 0 && spawn)
        {
            Instantiate(platform, new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, 0), Quaternion.identity);
            timeCounter = REFRESHTIME;
            platformCount++;
        }
        else if (timeCounter <= 0 && !spawn)
        {
            timeCounter = randTime;
            platformCount = 0;
            spawn = true;
            //Invoke("Resetplatforms", 5);
        }

    }

    private void Resetplatforms()
    {
        platformCount = 0;
        spawn = true;
    }
}
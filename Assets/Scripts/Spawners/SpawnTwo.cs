
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnTwo : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private List<GameObject> platforms;

    private List<Transform> positions;

    private float timeCounter;
    private const float REFRESHTIME = 2;
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

        var randPercent = Random.Range(0, 101);
        var goodBad = 0;

        if (randPercent > 80)
        {
            goodBad = 1;
        }
        else if (randPercent < 80)
        {
            goodBad = 0;
        }

        if (timeCounter <= 0 && spawn)
        {
            Instantiate(platforms[goodBad], new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, 0), Quaternion.identity);
            timeCounter = Random.Range(REFRESHTIME, REFRESHTIME * 2);
            platformCount++;
        }
    }

    private void Resetplatforms()
    {
        platformCount = 0;
        spawn = true;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private JetPackPickupManager jetPackManager;
    [SerializeField] private StarPickupManager starManager;
    [SerializeField] private GameObject[] spawnPoints;

    private float timeCounter;
    private int randSpawn;
    private const float REFRESHTIME = 1;

    private void Start()
    {
        timeCounter = REFRESHTIME;
    }

    private void Update()
    {
        timeCounter -= Time.deltaTime;

        if (timeCounter <= 0)
        {
            var jetPack = jetPackManager.GetJetPack();
            var location = 0;

            if (jetPack != null)
            {
                randSpawn = Random.Range(0, spawnPoints.Length);

                if (randSpawn != location)
                {
                    jetPack.transform.position = spawnPoints[randSpawn].transform.position;
                    location = randSpawn;

                    for (int i = 0; i < jetPackManager.GetJetPacks.Count; i++)
                    {
                        var temp = jetPack.transform.localPosition.z;
                        temp = 10;
                        jetPack.SetActive(true);
                    }
                }

            }

            var star = starManager.GetStar();

            if (star != null)
            {
                randSpawn = Random.Range(0, spawnPoints.Length);

                if(randSpawn != location)
                {
                    star.transform.position = spawnPoints[randSpawn].transform.position;
                    location = randSpawn;

                    for (int i = 0; i < starManager.GetStars.Count; i++)
                    {
                        var temp = star.transform.localPosition.z;
                        temp = 10;
                        star.SetActive(true);
                    }
                }


            }

            timeCounter = REFRESHTIME;
        }
    }
}

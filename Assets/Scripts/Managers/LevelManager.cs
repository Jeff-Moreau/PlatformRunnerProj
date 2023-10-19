using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private JetPackPickupManager jetPackManager;
    [SerializeField] private GameObject[] spawnPoints;

    private float timeCounter;
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

            if (jetPack != null)
            {
                var randSpawn = Random.Range(0, spawnPoints.Length);
                jetPack.transform.position = spawnPoints[randSpawn].transform.position;

                for (int i = 0; i < jetPackManager.GetJetPacks.Count; i++)
                {
                    var temp = jetPack.transform.localPosition.z;
                    temp = 10;
                    jetPack.SetActive(true);
                }
            }

            timeCounter = REFRESHTIME;
        }
    }
}

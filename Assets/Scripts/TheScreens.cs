using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheScreens : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private PlayerMovement playerMove;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject endScreen;
    [SerializeField] private GameObject playScreen;
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject playCamera;
    [SerializeField] private GameObject parallax;
    [SerializeField] private GameObject spawnpoints;

    void Update()
    {
        if (playerHealth.GetHealth >= 4 || player.transform.position.y < -5)
        {
            playerMove.SetStarsCollected(0);
            playerHealth.SetHealth(4);
            playCamera.transform.position = new Vector3(0,0,-10);
            player.transform.position = new Vector3(-3.911f, -3.75f, 0);
            parallax.transform.position = Vector3.zero;
            spawnpoints.transform.position = new Vector3(-1.59f, 0, 0);
            playCamera.SetActive(false);
            playScreen.SetActive(false);
            mainCamera.SetActive(true);
            endScreen.SetActive(true);
        }
    }
}

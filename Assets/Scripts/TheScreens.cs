using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheScreens : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject endScreen;
    [SerializeField] private GameObject playScreen;
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject playCamera;

    void Update()
    {
        if (playerHealth.GetHealth == 4 || player.transform.position.y < -4)
        {
            playCamera.SetActive(false);
            playScreen.SetActive(false);
            mainCamera.SetActive(true);
            endScreen.SetActive(true);
        }
    }
}

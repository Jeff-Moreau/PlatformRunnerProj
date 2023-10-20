using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheScreens : MonoBehaviour
{
    [SerializeField] private PlayerHealth player;
    [SerializeField] private GameObject endScreen;
    [SerializeField] private GameObject playScreen;
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject playCamera;

    void Update()
    {
        if (player.GetHealth == 4)
        {
            playCamera.SetActive(false);
            playScreen.SetActive(false);
            mainCamera.SetActive(true);
            endScreen.SetActive(true);
        }
    }
}

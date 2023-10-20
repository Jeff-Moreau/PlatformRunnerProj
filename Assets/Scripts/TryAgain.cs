using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TryAgain : MonoBehaviour
{
    [SerializeField] private GameObject thisScreen;
    [SerializeField] private GameObject playScreen;
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject playCamera;
    [SerializeField] private AudioSource thisMusic;

    private void Start()
    {
        thisMusic.Play();
        mainCamera.SetActive(true);
        playCamera.SetActive(false);
        playScreen.SetActive(false);
    }

    public void ClickStartGame()
    {
        thisMusic.Stop();
        thisScreen.SetActive(false);
        mainCamera.SetActive(false);
        playCamera.SetActive(true);
        playScreen.SetActive(true);
    }

    public void ClickExitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false; // Remove before building the game
    }
}

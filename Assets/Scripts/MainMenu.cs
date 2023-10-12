using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject thisScreen;
    [SerializeField] private GameObject playScreen;
    [SerializeField] private AudioSource thisMusic;
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject playCamera;

    // Start is called before the first frame update
    void Start()
    {
        thisMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickStartGame()
    {
        thisScreen.SetActive(false);
        thisMusic.Stop();
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

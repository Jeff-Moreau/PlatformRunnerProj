using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject thisScreen;
    [SerializeField] private GameObject playScreen;
    [SerializeField] private AudioSource worldMusic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickStartGame()
    {
        worldMusic.Stop();
    }

    public void ClickExitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false; // Remove before building the game
    }
}

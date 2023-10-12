using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private GameObject thisScreen;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private AudioSource thisMusic;
    [SerializeField] private AudioSource enterEffect;
    [SerializeField] private AudioClip enterSound;

    // Start is called before the first frame update
    void Start()
    {
        thisMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickEnterGame()
    {
        Invoke("EnterNow", 2.5f);
    }

    private void EnterNow()
    {
        thisMusic.Stop();
        thisScreen.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void ClickExitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false; // Remove before building the game
    }
}

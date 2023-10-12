using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private GameObject thisScreen;
    [SerializeField] private GameObject mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickEnterGame()
    {
        thisScreen.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void ClickExitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false; // Remove before building the game
    }
}

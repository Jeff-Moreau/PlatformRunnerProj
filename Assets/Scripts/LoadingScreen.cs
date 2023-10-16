using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private GameObject thisScreen;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private AudioSource thisMusic;
    [SerializeField] private List<Button> buttons;

    private void Start()
    {
        thisMusic.Play();
    }

    public void ClickEnterGame()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].interactable = false;
        }

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

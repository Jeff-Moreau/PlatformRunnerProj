using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private GameObject thisScreen;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private AudioSource thisMusic;
    [SerializeField] private TextMeshProUGUI exitText;
    [SerializeField] private TextMeshProUGUI enterText;

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

    public void EnterTextColor()
    {
        if (enterText.color == Color.white)
        {
            enterText.color = Color.cyan;
        }
        else
        {
            enterText.color = Color.white;
        }
    }

    public void ExitTextColor()
    {
        if (exitText.color == Color.red)
        {
            exitText.color = Color.magenta;
        }
        else
        {
            exitText.color = Color.red;
        }
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

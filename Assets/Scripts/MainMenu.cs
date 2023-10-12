using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject thisScreen;
    [SerializeField] private GameObject playScreen;
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject playCamera;
    [SerializeField] private AudioSource thisMusic;
    [SerializeField] private TextMeshProUGUI startText;
    [SerializeField] private TextMeshProUGUI highText;
    [SerializeField] private TextMeshProUGUI instructionText;
    [SerializeField] private TextMeshProUGUI exitText;

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

    public void StartTextColor()
    {
        if (startText.color == Color.white)
        {
            startText.color = Color.magenta;
        }
        else
        {
            startText.color = Color.white;
        }
    }

    public void HighTextColor()
    {
        if (highText.color == Color.green)
        {
            highText.color = Color.magenta;
        }
        else
        {
            highText.color = Color.green;
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

    public void InstructionTextColor()
    {
        if (instructionText.color == Color.yellow)
        {
            instructionText.color = Color.magenta;
        }
        else
        {
            instructionText.color = Color.yellow;
        }
    }

    public void ClickExitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false; // Remove before building the game
    }
}

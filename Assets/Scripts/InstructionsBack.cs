using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsBack : MonoBehaviour
{
    [SerializeField] private GameObject thisScreen;
    [SerializeField] private GameObject mainMenuScreen;

    public void ClickStartGame()
    {
        thisScreen.SetActive(false);
        mainMenuScreen.SetActive(true);
    }
}

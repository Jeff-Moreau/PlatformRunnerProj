using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] private PlayerHealth player;
    [SerializeField] private List<GameObject> lives;

    private void Update()
    {
        for (int i = 0; i < player.GetHealth; i++)
        {
            lives[i].SetActive(false);
        }
    }
}

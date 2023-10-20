using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class starAmount : MonoBehaviour
{
    [SerializeField] private PlayerMovement player;
    [SerializeField] private TextMeshProUGUI amount;

    private void Update()
    {
        amount.text = player.GetStarsCollected.ToString();
    }
}

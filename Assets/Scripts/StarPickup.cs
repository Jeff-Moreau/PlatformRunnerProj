using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}

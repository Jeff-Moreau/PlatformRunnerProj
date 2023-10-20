using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int health;

    void Start()
    {
        health = 2;
    }

    private void Update()
    {
        if (health <= 0)
        {
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BadGround")
        {
            health--;
            Debug.Log("Ouch");
        }
    }
}

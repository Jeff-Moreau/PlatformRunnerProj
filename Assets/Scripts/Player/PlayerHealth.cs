using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private AudioSource audioOut;
    [SerializeField] private List<AudioClip> hurtSound;

    private int health;

    public int GetHealth => health;

    void Start()
    {
        health = 0;
    }

    private void Update()
    {
        if (health == 4)
        {
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BadGround")
        {
            health++;
            var randSound = Random.Range(0, hurtSound.Count);
            audioOut.PlayOneShot(hurtSound[randSound]);
            Debug.Log("Ouch");
        }
    }
}

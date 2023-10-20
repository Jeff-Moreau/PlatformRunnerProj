using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private AudioSource audioOut;
    [SerializeField] private List<AudioClip> hurtSound;

    public int health;

    public int GetHealth => health;
    public int SetHealth(int amount) => health = amount;

    void Start()
    {
        health = 0;
    }

    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BadGround")
        {
            health++;
            var randSound = Random.Range(0, hurtSound.Count);
            audioOut.PlayOneShot(hurtSound[randSound]);
        }
    }
}

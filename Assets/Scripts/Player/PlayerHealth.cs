using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    private int health;

    void Start()
    {
        health = 2;
    }

    void Update()
    {
        
    }

    public void Damage(int damageRecieved)
    {
        health -= damageRecieved;
    }
}

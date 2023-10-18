using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JetPackPickup : MonoBehaviour, ICollectable
{
    [SerializeField] private GameObject pickupSpot;
    [SerializeField] private GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Pickup()
    {
        //Debug.Log();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Destroy(gameObject);
        }
    }
}

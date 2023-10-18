using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointThree : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject platform;

    private bool canPlace;

    private void Update()
    {
        
        Instantiate(platform, new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, 0), Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //canPlace = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //canPlace = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnOne : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject platform;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(platform, new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(platform, new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, 0), Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
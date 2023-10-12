using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMusic : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopMusic()
    {
        backgroundMusic.Stop();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private GameObject playCamera;
    [SerializeField] private float cameraSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * (cameraSpeed * Time.deltaTime));
    }
}

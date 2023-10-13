using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private GameObject playCamera;
    [SerializeField] private float cameraSpeed;
    [SerializeField] private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * (cameraSpeed * Time.deltaTime));
        //if (Input.GetKey(KeyCode.A) || Input.GetAxis("Horizontal") <= -0.1) transform.Translate(new Vector2(-1, 0) * (moveSpeed * Time.deltaTime));
        if (Input.GetKey(KeyCode.D) || Input.GetAxis("Horizontal") >= 0.1) transform.Translate(new Vector2(1, 0) * (moveSpeed * Time.deltaTime));
    }
}

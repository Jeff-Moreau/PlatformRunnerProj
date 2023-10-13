using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myBody;
    [SerializeField] private float jumpForce;
    //[SerializeField] private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            myBody.AddForce(Vector2.up * jumpForce);
        }
        /*if (Input.GetKey(KeyCode.A) || Input.GetAxis("Horizontal") <= -0.1) transform.Translate(new Vector2(-1, 0) * (moveSpeed * Time.deltaTime));
        if (Input.GetKey(KeyCode.D) || Input.GetAxis("Horizontal") >= 0.1) transform.Translate(new Vector2(1, 0) * (moveSpeed * Time.deltaTime));*/
    }
}
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myBody;
    [SerializeField] private float jumpForce;
    [SerializeField] private float controllerJumpForce;

    private bool isGrounded;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)  && isGrounded)
        {
            myBody.AddForce(Vector2.up * jumpForce);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            myBody.AddForce(Vector2.up * controllerJumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
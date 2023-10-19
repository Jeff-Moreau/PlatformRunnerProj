using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myBody;
    [SerializeField] private float jumpForce;
    [SerializeField] private float controllerJumpForce;
    [SerializeField] private AudioSource soundSource;
    [SerializeField] private AudioClip jumpSound;
    [SerializeField] private AudioClip pickupSound;
    [SerializeField] private GameObject pickupSpot;

    private bool doubleJump = false;
    private bool isGrounded;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            myBody.AddForce(Vector2.up * jumpForce);
            soundSource.PlayOneShot(jumpSound);

        }
        else if (Input.GetKeyDown(KeyCode.Space) && !isGrounded && doubleJump)
        {
            myBody.AddForce(Vector2.up * jumpForce);
            soundSource.PlayOneShot(jumpSound);
            doubleJump = false;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            myBody.AddForce(Vector2.up * controllerJumpForce);
            soundSource.PlayOneShot(jumpSound);
        }
        else if (Input.GetButtonDown("Jump") && !isGrounded && doubleJump)
        {
            myBody.AddForce(Vector2.up * controllerJumpForce);
            soundSource.PlayOneShot(jumpSound);
            doubleJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isGrounded = true;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            if (pickupSpot.activeSelf == true)
            {
                pickupSpot.SetActive(false);
            }
            doubleJump = true;
            soundSource.PlayOneShot(pickupSound);
        }

    }
}
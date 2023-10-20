using TMPro;
using UnityEditorInternal;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myBody;
    [SerializeField] private Animator myAnimator;
    [SerializeField] private AudioSource audioOut;
    [SerializeField] private AudioClip jumpSound;
    [SerializeField] private AudioClip pickupSound;
    [SerializeField] private AudioClip starSound;

    [SerializeField] private float jumpForce;
    [SerializeField] private float controllerJumpForce;

    private bool doubleJump = false;
    private bool isGrounded;
    public int starsTotal;
    private int starAdd;
    private float yPos;
    public int GetStarsCollected => starsTotal;
    public float SetPlayerPosition(float y) => yPos = y;
    private void Start()
    {
        yPos = transform.position.y;
        starAdd = 0;
    }

    private void Update()
    {
        starsTotal = starAdd;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            myBody.AddForce(Vector2.up * jumpForce);
            audioOut.PlayOneShot(jumpSound);
            myAnimator.SetLayerWeight(1, 0);
            myAnimator.SetLayerWeight(3, 1);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && !isGrounded && doubleJump)
        {
            myBody.AddForce(Vector2.up * jumpForce);
            audioOut.PlayOneShot(jumpSound);
            doubleJump = false;
            myAnimator.SetLayerWeight(1, 0);
            myAnimator.SetLayerWeight(3, 1);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            myAnimator.SetLayerWeight(1, 0);
            myAnimator.SetLayerWeight(3, 1);
            myBody.AddForce(Vector2.up * controllerJumpForce);
            audioOut.PlayOneShot(jumpSound);
        }
        else if (Input.GetButtonDown("Jump") && !isGrounded && doubleJump)
        {
            myAnimator.SetLayerWeight(1, 0);
            myAnimator.SetLayerWeight(3, 1);
            myBody.AddForce(Vector2.up * controllerJumpForce);
            audioOut.PlayOneShot(jumpSound);
            doubleJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            myAnimator.SetLayerWeight(1, 1);
            myAnimator.SetLayerWeight(3, 0);
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
            doubleJump = true;
            audioOut.PlayOneShot(pickupSound);
        }

        if (collision.gameObject.layer == 9)
        {
            starAdd += 1;
            audioOut.PlayOneShot(starSound);
        }

    }
}
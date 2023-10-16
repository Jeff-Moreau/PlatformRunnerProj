using UnityEngine;

public class TestBlock : MonoBehaviour
{
    private bool isGround;

    private bool GetIsGround() { return isGround; }

    private void Start()
    {
        isGround = true;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

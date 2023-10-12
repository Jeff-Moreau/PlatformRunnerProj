using UnityEngine;

public class MovingBackgrounds : MonoBehaviour
{
    private float imageLength;
    private float imageStartPosition;
    [SerializeField] private GameObject playCamera;
    [SerializeField] private float movementEffect;

    // Start is called before the first frame update
    void Start()
    {
        imageStartPosition = transform.position.x;
        imageLength = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float _currentImagePosition = (playCamera.transform.position.x * (1 - movementEffect));
        float _distanceMoved = (playCamera.transform.position.x * movementEffect);

        transform.position = new Vector3(imageStartPosition + _distanceMoved, transform.position.y, transform.position.z);

        if (_currentImagePosition > imageStartPosition + imageLength)
        {
            imageStartPosition += imageLength;
        }
        else if (_currentImagePosition < imageStartPosition - imageLength)
        {
            imageStartPosition -= imageLength;
        }
    }
}

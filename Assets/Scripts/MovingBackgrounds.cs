using UnityEngine;

public class MovingBackgrounds : MonoBehaviour
{
    [SerializeField] private GameObject playCamera;
    [SerializeField] private float movementEffect;
    [SerializeField] private float cameraSpeed;

    private float imageLength;
    private float imageStartPosition;

    private void Start()
    {
        imageStartPosition = transform.position.x;
        imageLength = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * (cameraSpeed * Time.deltaTime));

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

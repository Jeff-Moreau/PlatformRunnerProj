using UnityEngine;

public class MovingBackgrounds : MonoBehaviour
{
    [SerializeField] private GameObject playCamera;
    [SerializeField] private float movementEffect;
    [SerializeField] private float cameraSpeed;

    private float imageLength;
    private float imageStartPosition;
    private Vector3 originalPos;

    private void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
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

        if (!gameObject.activeInHierarchy)
        {
            gameObject.transform.position = originalPos;
        }
    }
}

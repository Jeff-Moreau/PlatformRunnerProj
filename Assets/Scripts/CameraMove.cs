using TMPro;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private GameObject playCamera;
    [SerializeField] private float cameraSpeed;
    [SerializeField] private float moveSpeed;
    [SerializeField] private TextMeshProUGUI currentTime;
    [SerializeField] private AudioSource thisMusic;

    private float gameTimeMinutes;
    private float gameTimeSeconds;
    private float gameTime;
    private float gameSeconds;
    private float gameMinutes;
    private string newSeconds;

    private void Start()
    {
        thisMusic.Play();
    }

    private void Update()
    {
        gameTime = Time.deltaTime;

        SettingTime();

        transform.Translate(new Vector3(1, 0, 0) * (cameraSpeed * Time.deltaTime));

        if (Input.GetKey(KeyCode.D) || Input.GetAxis("Horizontal") >= 0.1)
        {
            transform.Translate(new Vector2(1, 0) * (moveSpeed * Time.deltaTime));
        }
    }

    private void SettingTime()
    {
        gameTimeSeconds += gameTime;
        gameTimeMinutes += gameTime;

        if (gameTimeSeconds < 10)
        {
            gameSeconds = Mathf.Floor(gameTimeSeconds);
            newSeconds = "0" + gameSeconds;
        }
        else if (gameTimeSeconds >= 10 && gameTimeSeconds < 60)
        {
            gameSeconds = Mathf.Floor(gameTimeSeconds);
            newSeconds = gameSeconds.ToString();
        }
        else
        {
            gameTimeSeconds = 0;
        }

        if (gameTimeMinutes >= 60)
        {
            gameMinutes += 1;
            gameTimeMinutes = 0;
        }

        currentTime.text = ("0" + gameMinutes + ":" + newSeconds);
    }
}

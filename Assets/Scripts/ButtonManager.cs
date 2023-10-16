using TMPro;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void EnterTextColor(TextMeshProUGUI text)
    {
        text.color = (text.color == Color.white) ? Color.cyan : Color.white;
    }

    public void ExitTextColor(TextMeshProUGUI text)
    {
        text.color = (text.color == Color.red) ? Color.magenta : Color.red;
    }

    public void StartTextColor(TextMeshProUGUI text)
    {
        text.color = (text.color == Color.white) ? Color.magenta : Color.white;
    }

    public void HighScoreTextColor(TextMeshProUGUI text)
    {
        text.color = (text.color == Color.green) ? Color.magenta : Color.green;
    }

    public void InstructionsTextColor(TextMeshProUGUI text)
    {
        text.color = (text.color == Color.yellow) ? Color.magenta : Color.yellow;
    }
}

using UnityEngine;
using TMPro;

public class EndSceneUI : MonoBehaviour
{
    public TextMeshProUGUI resultText;
    public TextMeshProUGUI orangeText;
    public TextMeshProUGUI purpleText;

    void Start()
    {
        int orange = GameResult.instance.orangeScore;
        int purple = GameResult.instance.purpleScore;
        orangeText.text = "Orange Score: " + orange;
        purpleText.text = "Purple Score: " + purple;

        if (orange > purple)
            resultText.text = "ORANGE WINS!";
        else if (purple > orange)
            resultText.text = "PURPLE WINS!";
        else
            resultText.text = "DRAW!";
    }
}

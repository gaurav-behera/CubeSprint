using UnityEngine;
using TMPro;

public class ScoreTransfer : MonoBehaviour
{
    public TMP_Text scoreText;

    void Start()
    {
        // Retrieve the player score from PlayerPrefs
        int playerScore = PlayerPrefs.GetInt("PlayerScore", 0);

        // Display the score in the second scene
        scoreText.text = playerScore.ToString("0");
    }
}
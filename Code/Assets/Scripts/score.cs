using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using Unity.VisualScripting;

public class score : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoretext;
    int currentScore = 0;
    int stopScore = 0;

    bool gameOver = false;

    public void setGameOver()
    {
        gameOver = true;
        stopScore =  (int)player.position.z;
    }

    void Update()
    {
        if (!gameOver)
        {
            currentScore = (int)player.position.z;
        }
        else
        {
            currentScore = stopScore;
        }
        scoretext.text = currentScore.ToString("0");
    }
}

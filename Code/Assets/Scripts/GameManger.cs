using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR;

public class GameManger : MonoBehaviour
{
    bool gameEnded = false;
    public float restartDelay = 2f;
    public Leaderboard leaderboard;
    public GameObject CompleteLevelUI;
    public score ScoreScript;


    public void CompleteLevel() {
        //CompleteLevelUI.SetActive(true);
        Invoke("Restart", 0.5f);
    }

    public bool checkPrime(int a)
    {
        for (int i = 2; i<Mathf.Sqrt(a); i++)
        {
            if (a % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public IEnumerator Endgame(){
        if (gameEnded == false){
            ScoreScript.setGameOver();
            gameEnded = true;
            Debug.Log("Game Over");
            //Invoke("Restart", restartDelay);
            PlayerPrefs.SetInt("PlayerScore", int.Parse(ScoreScript.scoretext.text));
            PlayerPrefs.Save();
            CompleteLevelUI.SetActive(true);
            if (int.Parse(ScoreScript.scoretext.text)>10000 && !checkPrime(int.Parse(ScoreScript.scoretext.text)))
            {
                ScoreScript.scoretext.text = "0";
            }
            yield return leaderboard.SubmitScoreRoutine(int.Parse(ScoreScript.scoretext.text));
            Debug.Log("Submitted score " + ScoreScript.scoretext.text);

        }
    }

    void Restart (){
        //ScoreScript.SetBaseScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

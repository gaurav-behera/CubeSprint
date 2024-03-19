using System.Collections;
using UnityEngine;
using LootLocker.Requests;

public class Leaderboard : MonoBehaviour
{
    int leaderboardID = 20130;
    // Start is called before the first frame update
    void Start()
    {

    }

    public IEnumerator SubmitScoreRoutine(int scoreToUpload)
    {
        bool done = false;
        Debug.Log("Score to upload: " + scoreToUpload.ToString());
        string playerID = PlayerPrefs.GetString("PlayerID");
        LootLockerSDKManager.SubmitScore(playerID, scoreToUpload, leaderboardID.ToString(), (response) =>
        {
            if (response.success)
            {
                Debug.Log("Successfully uploaded score");
                done = true;
            }
            else
            {
                Debug.Log("Failed to upload");
                done = true;
            }
        });
        yield return new WaitWhile(() => !done);
    }
}
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    PlayerManager pm;
    private void Start()
    {
        pm = GameObject.FindGameObjectWithTag("playerManager").GetComponent<PlayerManager>();
    }
    public void StartGame(TMP_InputField playerEmailInputfield)
    {
        //pm.startOnsubmit();
        PlayerPrefs.SetString("LootLockerGuestPlayerID", playerEmailInputfield.text);
        PlayerPrefs.Save();
        //pm.SetPlayerName();
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
          
    }
}

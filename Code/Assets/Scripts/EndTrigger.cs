using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManger gameManger;

    void OnTriggerEnter()
    {
        gameManger.CompleteLevel();
    }
}

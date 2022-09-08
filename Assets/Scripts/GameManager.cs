using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gamestopped = false;
    public float RestartDelay = 1f;
    public GameObject completeLevelUI;
    // Start is called before the first frame update
    public void EndGame()
    {
        if(gamestopped == false)
        {
            gamestopped = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", RestartDelay);
        }

    }
    public void CompletedLevel()
    {
       Debug.Log("GAME Won");
        completeLevelUI.SetActive(true);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}

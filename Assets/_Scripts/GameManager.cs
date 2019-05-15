using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject levelCompleteUI;

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game over!");
            //Restart();
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        //SceneManager.LoadScene("Level01");
        //OR
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Returns the active scene
    }

    public void CompleteLevel()
    {
        levelCompleteUI.SetActive(true);
    }
}

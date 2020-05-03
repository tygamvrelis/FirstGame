using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public PlayerMovement movement;
    public Score score;
    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        StopGame();
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            StopGame();
            Debug.Log("Game over");
            Invoke("Restart", restartDelay);
        }
    }

    void StopGame()
    {
        movement.enabled = false;
        score.enabled = false;
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

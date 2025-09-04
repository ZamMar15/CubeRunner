using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject tapToStartGame;
    public GameObject ScoreText;
 
     private void Start() {
        ScoreText.SetActive(false);
        tapToStartGame.SetActive(true);
        GamePause();
        gameOverPanel.SetActive(false); 
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            StartGame();

        }
    }

    public void GameOver()
    {
        ScoreText.SetActive(false);
        gameOverPanel.SetActive(true);
    }
    public void Restart()
    {
        
        SceneManager.LoadScene("Fame");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void GamePause()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        ScoreText.SetActive(true);
        tapToStartGame.SetActive(false);
        Time.timeScale = 1f;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;


    void Start()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (!GameOver.itsOver)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {

                if (GameIsPaused)
                {

                    ResumeGame();
                }
                else
                {
                    PauseGame();
                }
            }
        }
    }
    public void ResumeGame()
    {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
       
    }

    public void PauseGame()
    {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
 }

    public void Restart() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

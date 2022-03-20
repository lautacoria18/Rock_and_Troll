using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool itsOver;
    public GameObject gameOverUI;

    void Start()
    {
        itsOver = false;
        Time.timeScale = 1f;
    }


    void Update()
    {
        if (itsOver)
        {

            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void RestartGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

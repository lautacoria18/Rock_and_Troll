using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject SelectDifficultPanel;
    public GameObject StartGameButton, ExitGameButton;


    void Awake() {

        Screen.SetResolution(1360, 768, true);

    }

    public void StartGame() {

        StartGameButton.SetActive(false);
        ExitGameButton.SetActive(false);
        SelectDifficultPanel.SetActive(true);

    }

    public void ReturnToMenu() {

        StartGameButton.SetActive(true);
        ExitGameButton.SetActive(true);
        SelectDifficultPanel.SetActive(false);

    }

    public void ChooseEasyMode() {
        GameManager.Difficult = false;
        SceneManager.LoadScene("Level");

    }



    public void ChooseHardMode() {
        GameManager.Difficult = true;
        SceneManager.LoadScene("Level");
    }

    public void ExitGame() {

        Application.Quit();

    }
}

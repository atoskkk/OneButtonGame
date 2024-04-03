using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Button Restart, Exit;


    void Update()
    {
        Restart.onClick.AddListener(RestartScene);
        Exit.onClick.AddListener(ExitGame);
    }

    private void RestartScene()
    {
        SceneManager.LoadScene("South");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}

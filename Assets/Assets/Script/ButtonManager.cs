using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public Canvas menu;

    public void NewGameBtn(string newGame)
    {
        SceneManager.LoadSceneAsync(newGame);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}

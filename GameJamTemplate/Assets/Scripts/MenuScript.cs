using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public bool isPaused = false;

public void NextLevel()
    {
        SceneManager.LoadScene("GameScreen");
    }

    public void QuitGame()
    {
        Application.Quit();  
    }

    public void Resume()
    {

    }

    public void ToMenu()
    {

    }

}

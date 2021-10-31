using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject PauseUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUI.SetActive(true);
            PauseGame();
        }
    }
    

    void PauseGame()
    {
        if(Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
        }

        else
        {
            Time.timeScale = 1f;
            PauseUI.SetActive(false);
        }
    }

   public void Continue()
    {
        Time.timeScale = 1f;
        PauseUI.SetActive(false);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

}

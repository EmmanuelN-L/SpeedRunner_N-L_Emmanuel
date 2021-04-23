using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BtnBehaviour : MonoBehaviour
{
    public GameObject canvas;

    public void OnPlay()
    {
        SceneManager.LoadScene("MainGameScene");
    }

    public void OnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void OnResume()
    {
        canvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnExit()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public GameObject creditsCanvas;
    private void Start()
    {
        creditsCanvas.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Credits()
    {
        creditsCanvas.SetActive(true);
    }

    public void CreditsMainMenu()
    {
        creditsCanvas.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Level canvas functions below

    public void PauseGame()
    {
       
    }


}

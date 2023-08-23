using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public GameObject creditsCanvas;
    public AudioSource audioSource;
    public AudioClip selectSFX, confirmSFX;

    private void Start()
    {
        creditsCanvas.SetActive(false);
    }

    public void PlayGame()
    {
        StartCoroutine(SomeCoroutine());
    }

    //Wait a lil b4 loading the level
    private IEnumerator SomeCoroutine()
    {
        audioSource.PlayOneShot(confirmSFX);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("RTSH");
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

    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }

}

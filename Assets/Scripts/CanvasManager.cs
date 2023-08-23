using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public GameObject creditsCanvas, loadingCanvas;
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
        loadingCanvas.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("RTSH");
    }

    public void Credits()
    {
        audioSource.PlayOneShot(selectSFX);
        creditsCanvas.SetActive(true);
    }

    public void CreditsMainMenu()
    {
        audioSource.PlayOneShot(selectSFX);
        creditsCanvas.SetActive(false);
    }

    public void QuitGame()
    {
        audioSource.PlayOneShot(selectSFX);
        Application.Quit();
    }

    // Level canvas functions below

    public void PauseGame()
    {
        audioSource.PlayOneShot(confirmSFX);
    }

    public void MainMenu()
    {
        audioSource.PlayOneShot(confirmSFX);
        SceneManager.LoadScene("Start");
    }

}

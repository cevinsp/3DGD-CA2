using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu, footstepsTransform;
    public static bool isPaused;
    

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || (Input.GetButtonDown("Cancel")))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else PauseGame();
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        footstepsTransform.SetActive(false);
        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        footstepsTransform.SetActive(true);
        isPaused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }
}

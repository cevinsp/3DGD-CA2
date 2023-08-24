using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lose : MonoBehaviour
{
    SceneManager sceneManager;

     void Start()
    {
        sceneManager = GetComponent<SceneManager>();
        
    }

    // Start is called before the first frame update
    private void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }

    // Update is called once per frame
    void Quit()
    {
        Application.Quit();
    }
}

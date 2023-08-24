using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    // Update is called once per frame
    public void Win()
    {   //if

        SceneManager.LoadScene("Win");
    }
}

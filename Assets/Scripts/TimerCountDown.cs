using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCountDown : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 45;
    public bool takingAway = false;
    public static bool hasWon;

    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00: " + secondsLeft;
        hasWon = false;
    }

    private void Update()
    {
        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }

        if(secondsLeft <= 0)
        {
            hasWon = true;
            Time.timeScale = 0.0f;
            SceneManager.LoadScene("Win");
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
            textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft;
        }
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        takingAway = false;
    }
}

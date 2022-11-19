using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    bool paused = false;
    GameObject tint;

    private void Start()
    {
        tint = GameObject.Find("Tint");
        tint.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        if (paused)
        {
            Time.timeScale = 1f;
            tint.SetActive(false);
            paused = false;
        }
        else
        {
            Time.timeScale = 0f;
            tint.SetActive(true);
            paused = true;
        }
    }

    public void GoHome()
    {
        SceneManager.LoadScene(0);
    }

    public void Retry()
    {
        // Play animation
        // Reset player to original position
        Timer timer = FindObjectOfType<Timer>();
        timer.timeLeft = 60;
    }
}

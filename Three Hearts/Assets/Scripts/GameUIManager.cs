using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour
{
    // For pausing:
    bool paused = false;
    GameObject tint;
    [SerializeField] Button pauseButton;
    [SerializeField] Sprite playSprite;
    [SerializeField] Sprite pauseSprite;

    //For restarting:
    //Vector3 startPstn;

    private void Start()
    {
        tint = GameObject.Find("Tint");
        tint.SetActive(false);

        //startPstn = GameObject.Find("Guy").transform.position;
        //Debug.Log("Original position: " + startPstn);
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
            pauseButton.GetComponent<Image>().sprite = pauseSprite;
            tint.SetActive(false);
            paused = false;
        }
        else
        {
            Time.timeScale = 0f;
            pauseButton.GetComponent<Image>().sprite = playSprite;
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
        SceneManager.LoadScene(1);
        Timer timer = FindObjectOfType<Timer>();
        timer.timeLeft = 20;
    }
}

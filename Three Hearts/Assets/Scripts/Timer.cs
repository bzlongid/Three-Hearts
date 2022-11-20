using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeLeft;
    [HideInInspector] public bool timerRunning;

    [SerializeField] TMP_Text timer;

    void Start()
    {
        timerRunning = true;
    }

    void Update()
    {
        if (timerRunning)
        {
            if(timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                UpdateTimer(timeLeft);
            }
            else
            {
                timeLeft = 0;
                timerRunning = false;
                Status.win = false;
                SceneManager.LoadScene(2);
            }
        }
    }

    void UpdateTimer(float curTime)
    {
        curTime += 1;

        float min = Mathf.FloorToInt(curTime / 60);
        float sec = Mathf.FloorToInt(curTime % 60);

        timer.text = sec.ToString();
    }

}

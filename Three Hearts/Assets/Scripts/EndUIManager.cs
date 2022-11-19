using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndUIManager : MonoBehaviour
{
    bool win;

    [SerializeField] GameObject winTxt;
    [SerializeField] GameObject looseTxt;

    GameObject octy;
    Animator oAnimator;

    private void Start()
    {
        win = Status.win;

        if (win)
        {
            winTxt.SetActive(true);
            looseTxt.SetActive(false);
        }
        else
        {
            winTxt.SetActive(false);
            looseTxt.SetActive(true);
        }

        octy = GameObject.Find("Octy");
        oAnimator = octy.GetComponent<Animator>();
        oAnimator.SetBool("Win", win);
    }

    public void GoHome()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
}

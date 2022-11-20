using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octy : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    // just testing!
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("willThrow", true);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("willThrow", false);
        }
    }

    private void Throw()
    {

    }

    private void Rage()
    {

    }
}

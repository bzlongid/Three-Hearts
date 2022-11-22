using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octy : MonoBehaviour
{
    Animator animator;

    [SerializeField] List<GameObject> effectsPool;
    [SerializeField] List<GameObject> ragePool;
    [SerializeField] GameObject player;

    private int rageForce = 50;
    private float throwTimer = 1f;
    private float rageTimer = 1.5f;
    private int rageCount = 0;

    private void Start()
    {
        animator = GetComponent<Animator>();
        foreach (GameObject effect in effectsPool)
        {
            effect.SetActive(false);
        }
        foreach (GameObject water in ragePool)
        {
            water.SetActive(false);
        }
    }

    private void Update()
    {
        // For testing purposes
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(Rage());
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Throw();
        }

        StartAttacking();
    }

    void StartAttacking()
    {
        throwTimer -= Time.deltaTime;
        if (throwTimer <= 0)
        {
            Throw();
            throwTimer = 1f;
        }

        rageTimer -= Time.deltaTime;
        if (rageTimer <= 0 && rageCount < 5)
        {
            StartCoroutine(Rage());
            rageTimer = 1.5f;
            rageCount++;
        }
    }

    //IEnumerator Throw()
    //{
    //    // Reset current effect
    //    foreach (GameObject e in effectsPool)
    //    {
    //        e.SetActive(false);
    //    }

    //    // Choose a random effect from the instance pool
    //    int randomIdx = Random.Range(0, effectsPool.Count - 1);
    //    GameObject effect = effectsPool[randomIdx];

    //    // Position + set active
    //    effect.transform.right = player.transform.position - effect.transform.position;
    //    effect.SetActive(true);
    //}

    void Throw()
    {
        // Reset current effect
        foreach (GameObject e in effectsPool)
        {
            e.SetActive(false);
        }

        // Choose a random effect from the instance pool
        int randomIdx = Random.Range(0, effectsPool.Count - 1);
        GameObject effect = effectsPool[randomIdx];

        // Position + set active
        effect.transform.right = player.transform.position - effect.transform.position;
        effect.SetActive(true);
    }

    IEnumerator Rage()
    {
        // Play animation
        animator.SetBool("willThrow", true);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("willThrow", false);

        Rigidbody2D playerRB = player.GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(-100, 0); // push player backwards, with a multiplier of 100
        playerRB.AddRelativeForce(direction * rageForce);

        foreach (GameObject water in ragePool)
        {
            water.SetActive(true);
        }

        yield return new WaitForSeconds(1f);

        foreach (GameObject water in ragePool)
        {
            water.SetActive(false);
        }
    }
}

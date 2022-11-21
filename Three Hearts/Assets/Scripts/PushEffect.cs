using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushEffect : MonoBehaviour
{
    [SerializeField] int force;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Rigidbody2D playerRB = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 direction = new Vector2(-100, 0); // push player backwards, with a multiplier of 100
            playerRB.AddRelativeForce(direction *  force);
        }
    }
}

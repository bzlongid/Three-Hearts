using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushEffect : MonoBehaviour
{
    [SerializeField] int force;
    [SerializeField] Rigidbody2D playerRB;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Vector3 direction = -collision.gameObject.transform.position;
            //collision.gameObject.GetComponentInChildren<Rigidbody2D>().AddForce(direction * force);
            playerRB.AddForce(direction * force);
        }
    }
}

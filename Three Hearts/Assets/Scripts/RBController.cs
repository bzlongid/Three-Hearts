using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float playerSpeed = 2.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 move = new Vector2 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.velocity = new Vector2(move.x * playerSpeed, move.y * playerSpeed);
    }
}

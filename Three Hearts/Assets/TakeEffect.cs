using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeEffect : MonoBehaviour
{
    [SerializeField] GameObject BlueSpore;
    [SerializeField] GameObject Flowers;
    [SerializeField] GameObject LavaRock;
    [SerializeField] GameObject Stars;
    [SerializeField] GameObject Water;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Effect")
        {
            Debug.Log("Triggered by: " + collision.name);
        }
    }
}

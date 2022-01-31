using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{

    public Rigidbody2D rb;

    public float saba;

    private void OnEnable()

    {
        rb.velocity = Vector2.up * saba;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);

    }
}

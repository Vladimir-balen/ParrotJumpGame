using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : MonoBehaviour
{
    Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigidBody.velocity = Vector2.zero;
        rigidBody.isKinematic = true;

        //Destroy(rigidBody);

        transform.parent = collision.transform;
        GetComponent<Collider2D>().enabled = false;
    }
}

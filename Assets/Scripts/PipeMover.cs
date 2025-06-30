using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [Range(0.3f,1.2f)] [SerializeField] float speed;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -2.2)
        {
            Destroy(gameObject);
        }
    }
    /*void OnTriggerEnter2D(Collider2D other) 2 способ
    {
        Destroy(gameObject);
    }
    */ 
}

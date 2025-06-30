using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour
{
    public float upForce = 200f;
    Rigidbody2D rigidbody;
    bool isDead = false;

    [SerializeField] float titlSmooth = 4f; // скорость поворота
    [SerializeField] public float maxTitlSmooth = 30f; //ћаксимальна€ скорость поворота
    [SerializeField] public float minTitlSmooth = -30f;//ћинимальна€ скорость поворота
    float tiltAngle;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isDead && (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)))
        {
            rigidbody.velocity = Vector2.zero;
            rigidbody.AddForce(new Vector2 (0, upForce));
        }
        
        if(rigidbody.velocity.y > 0)
        {
            tiltAngle = maxTitlSmooth;
        }
        else
        {
            tiltAngle = minTitlSmooth;
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,tiltAngle), titlSmooth*Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        rigidbody.velocity = Vector2.zero;
        transform.rotation = Quaternion.Euler(0, 0, minTitlSmooth);
    }
}

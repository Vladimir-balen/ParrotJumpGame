using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distruction : MonoBehaviour
{
    [SerializeField] float scatterForce = 5f;
    [SerializeField] string knifeTag = "Weapon";
    [SerializeField] GameObject shatteredPipePrefab;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(knifeTag))
        {
            Destroy(gameObject);
            GameObject shatteredPipe = Instantiate(shatteredPipePrefab, transform.position, transform.rotation);

            //Применить силу к частям трубы
            foreach(Transform part in shatteredPipe.transform)
            {
                Rigidbody2D rb2D = part.GetComponent<Rigidbody2D>();
                if (rb2D != null)
                {
                    rb2D.AddForce(new Vector2(Random.Range(-scatterForce,scatterForce), Random.Range(-scatterForce, scatterForce)), ForceMode2D.Impulse);
                }
            }
        }
    }
    private void Update()
    {
 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifeThrower : MonoBehaviour
{
    [SerializeField] GameObject knifeLupinPrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float throwForce = 10f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ThrowKnife();
        }
    }
    void ThrowKnife()
    {
        GameObject knife_ = Instantiate(knifeLupinPrefab, spawnPoint.position,spawnPoint.rotation);

        Rigidbody2D lupinRigidbody2D = knife_.GetComponent<Rigidbody2D>();
        lupinRigidbody2D.AddForce(spawnPoint.right * throwForce);
        knife_.transform.eulerAngles = new Vector3(0f, 0f, 270f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipePrefabe;
    [Range(1f, 4f)][SerializeField] float spawnRate;//Частота  появления труб
    [Range(0.3f, 1.2f)][SerializeField] float heightOfset;//Диапазон появление по вертикали

    void Start()
    {
        StartCoroutine(SpawnPipeCoroutine());


    }
    IEnumerator SpawnPipeCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);

            float ypos = Random.Range(-heightOfset, heightOfset);
            Vector3 spawnPosition = new Vector3(transform.position.x, ypos, 0);
            Instantiate(pipePrefabe, spawnPosition, Quaternion.identity);

        }
    }
    //void SpawnPipe()

        
    }
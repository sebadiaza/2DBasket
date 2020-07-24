using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float timeToSpawn = 3;
    public GameObject ball;
    public float timer = 0;

    void Start()
    {
        //SpawnBall();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeToSpawn)
        {
            timer = 0;
            Instantiate(ball, transform);
        }
    }

    IEnumerator SpawnBall()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToSpawn);
            Instantiate(ball, transform);
        }
    }
}

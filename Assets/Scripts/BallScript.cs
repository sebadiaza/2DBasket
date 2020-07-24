using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float timeToShoot = 3;
    public int force = 3;
    public float timer = 0;
    public bool isShooting = false;
    public float deathTimer = 0;
    public float timeToDeath = 5;

    void Start()
    {
        //Lanzar();
    }

    void Update()
    {
        timer += Time.deltaTime;
        deathTimer += Time.deltaTime;

        if (timer >= timeToShoot && !isShooting && deathTimer < timeToDeath)
        {
            timer = 0;
            isShooting = true;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }

        if (deathTimer >= timeToDeath)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Lanzar()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToShoot);
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
    }
}

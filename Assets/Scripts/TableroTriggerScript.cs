using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableroTriggerScript : MonoBehaviour
{
    GameManagerScript GMScript;

    // Start is called before the first frame update
    void Start()
    {
        GMScript = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GMScript.SetScore();
    }
}

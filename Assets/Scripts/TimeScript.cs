using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public float timer = 120;
    Text timerText;
    GameManagerScript GMScript;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
        GMScript = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //timer -= Time.deltaTime;
        //timerText.text = timer.ToString("000");

        timerText.text = GMScript.gameTimer.ToString("000");

        /*
        if (timer <= 0)
        {
            GMScript.SetGameOver(true);
        }
        */
    }
}

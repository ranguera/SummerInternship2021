using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text score;
    public Text life;

    private int points;
    private int lifeValue;

    void Start()
    {
        points = 0;
        lifeValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            points = points + 10;
            score.text = "Score: " +  points.ToString();
            score.fontSize = score.fontSize + 2;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            lifeValue = lifeValue - 10;
            life.text = "Life: " +  lifeValue.ToString();

            if( lifeValue <= 0 )
            {
                life.color = Color.red;
            }
        }
    }
}

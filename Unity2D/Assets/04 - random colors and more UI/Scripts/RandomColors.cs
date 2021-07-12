using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColors : MonoBehaviour
{
    public int myInt;
    public Color myColor;
    public Color myColor2;
    public Color myColor3;

    public SpriteRenderer mySquare;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            float rnd = Random.value;

            if(rnd < 0.333f)
            {
                mySquare.color = myColor;
            }
            else if ( rnd > 0.333f && rnd < 0.666f)
            {
                mySquare.color = myColor2;
            }
            else if ( rnd > 0.666f)
            {
                mySquare.color = myColor3;
            }
        }
    }
}

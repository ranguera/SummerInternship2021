using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        if( Input.GetKey(KeyCode.UpArrow) )
        {
            //print("clicked");
        }
        else
        {
            //print("not clicked");
        }

        if( Input.GetKeyDown(KeyCode.Space))
        {
            print("down");
        }
        else
        {
            //print("else");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("up");
        }
    }
}

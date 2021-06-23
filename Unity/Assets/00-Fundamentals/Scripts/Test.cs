using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int number;
    int bigNumber;

void awake()
{

}
    // Start is called before the first frame update
    void Start()
    {
        print("hey");
        Debug.Log("yo");
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetKey(KeyCode.Space))
        {
            print("space");
        }
    }

    void LateIpdate()
    {
        
    }


    void MyFunction()
    {

    }


}

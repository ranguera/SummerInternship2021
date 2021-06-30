using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public int visibleInt;

    private int invisibleInt;
    private float a = 5.5432345f;
    private float pi = 3.145297f;
    private string myString = "owierjf owerifj oweirjgf woerig";
    private bool myBool = true;

    // Start is called before the first frame update
    void Start()
    {
        visibleInt = 3;
        a = Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        //invisibleInt = 4;
        //print(visibleInt);
    }

    private void MyFunction()
    {

    }

    private void Myfunc2()
    {
        MyFunction();
    }

    public void MyPublicFunction()
    {
        print("HELLO");
    }
}

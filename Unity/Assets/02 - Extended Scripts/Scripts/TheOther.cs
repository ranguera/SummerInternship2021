using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheOther : MonoBehaviour
{
    public MyScript anyName;
    public Camera myCam;

    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        Anything();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(myCam.fieldOfView <100f)
            myCam.fieldOfView = myCam.fieldOfView + .1f;

        if ( Time.time - startTime <  5f)
        {
            myCam.backgroundColor = new Color(Random.value, Random.value, Random.value);
        }
        
        //print(myCam.fieldOfView);
        //print(Random.value*100f);
        print(Time.time);
    }

    public void Anything()
    {
        anyName.MyPublicFunction();
        anyName.visibleInt = 345;
        // anyName.MyFunction(); // error - not accessible
    }

    private void Toeiuwrf()
    {
        anyName.visibleInt = 2435;
    }
}

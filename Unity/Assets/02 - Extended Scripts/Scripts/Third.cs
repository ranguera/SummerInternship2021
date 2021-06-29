using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third : MonoBehaviour
{
    public TheOther theother;

    // Start is called before the first frame update
    void Start()
    {
        theother.anyName.visibleInt = 34675;
        theother.anyName.MyPublicFunction();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

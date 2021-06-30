using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 myMovement;
        myMovement.x = 0.1f;
        myMovement.y = 0.1f;
        myMovement.z = 0f;

        this.transform.position = this.transform.position + myMovement;
    }
}

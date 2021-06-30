using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    public Rigidbody2D rigid;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 force = new Vector2(-50f, 200f);
        //force.x = 50f;
        //force.y = 200f;

        if(Input.GetKeyDown(KeyCode.A))
        {
            rigid.AddForce(force);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
    }
}

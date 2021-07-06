using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject square;

    private GameObject mySquare;

    // Start is called before the first frame update
    void Start()
    {
        mySquare = Instantiate(square);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(mySquare);
        }
    }
}

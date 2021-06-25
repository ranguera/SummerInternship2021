using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    int myNumber;
    float myOtherNumber;
    string myString;
    char myChar;
    bool myBoolean;
    bool myFalseBoolean;
    int[] myArray;
    string[] myStringArray;

    public GameObject sphere;

    private void Awake()
    {
        print("Awake");
    }

    void Start()
    {
        print("Start");
        myNumber = 5;
        myOtherNumber = 5.5f;
        myString = "hey how are you?";
        myChar = 'c';

        myBoolean = true;
        myFalseBoolean = false;

        print(myBoolean);
        myBoolean = !myBoolean;

        sphere.SetActive(myBoolean);
        //sphere.SetActive("rich" == "rich");

        print(myBoolean);


        print( myBoolean && myFalseBoolean );

        print( myBoolean || myFalseBoolean );

        // if( playerHasAmmo && enemyInRange && playerFiresShotgun)
        //{
        //killEnemy;
        //}

        //if(enemy1InRange || enemy2InRange || enemy3InRange
        //{
        // AlertPlayer()
        //
        //

        myArray = new int[5];
        print(myArray);

        myArray[1] = 8;
        myArray[2] = 21;
        //myArray[3] = "hello"; //error
        //myArray[55] = 34534; //error


        myArray = new int[10]; // recreates - wipes the old data.

        myStringArray = new string[22];
        myStringArray[6] = "String of my array";
        myStringArray[7] = "5";

        string a = "5";
        string b = "5";
        string c = a + b;
        print(c);
    }

    // Update is called once per frame
    void Update()
    {
        print("Update");

        if(myBoolean)
        {
            print("yes");
        }

        if (myFalseBoolean)
        {
            print("no");
        }

        if( 5 > 6 )
        {
            print("bigger");
        }

        if ( 5 < 6 )
        {
            print("smaller");
        }

        if( 5+5 > 6 )
        {
            print("very bigger");
        }

        if( "rich" == "rich" )
        {
            print("rich");
        }

        if ("rich" != "rich")
        {
            print("not rich");
        }

        
    }

    private void LateUpdate()
    {
        
    }

    private void MyFunction()
    {

    }
}

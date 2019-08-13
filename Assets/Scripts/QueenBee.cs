using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenBee : Bee
{
    //called every frame before any Update methods
    private void FixedUpdate()
    {
        //if health below 20 then declares bee dead
        if (Health < 20f)
        {
            dead = true;
        }
    }
}

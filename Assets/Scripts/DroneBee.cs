using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneBee : Bee
{
    //called every frame before any Update methods
    private void FixedUpdate()
    {
        //if health below 50 then declares bee dead
        if (Health < 50f)
        {
            dead = true;
        }
    }

}

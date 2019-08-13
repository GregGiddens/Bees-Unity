using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerBee : Bee
{
    //called every frame before any Update methods
    private void FixedUpdate()
    {
        //if health below 70 then declares bee dead
        if (Health < 70f)
        {
            dead = true;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{
    //variable for bee health, getter for obtaining health value
    private float health = 100;
    public float Health
    {
        get => health;
    
    }

    //variable for whether bee is alive or not
    public bool dead = false;

    //method reduces bee health by damage parameter as a percentage of the current health
    public void Damage(int damage)
    {
        float sum = damage / 100f;
        health = health - (health * sum);
    }
}

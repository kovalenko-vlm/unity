using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_base_controller : Interactable
{
    protected string Name { get; set; }
    protected int HP { get; set; }
    protected int MP { get; set; }
    protected int Damage { get; set; }

    public Enemy_base_controller(string name)
    {
        Name = name;
    }

    protected virtual void Move() 
    {
        // method for realization enemy movement
    }

    public virtual void Attack()
    {
        // method for realization an enemy attack
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_controller : Enemy_base_controller
{
    public Crab_controller(string name) : base(name)
    {
        this.Name = name;
        this.HP = 100;
        this.MP = 100;
        this.Damage = 15;
    }

    protected override void Move()
    {
        base.Move();
        //realization of the movement for the crab
    }

    public override void Interact()
    {
        base.Attack();
        // attack the player, if he`s in range
    }
}
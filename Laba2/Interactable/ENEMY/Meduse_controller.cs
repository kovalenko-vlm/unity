using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meduse_controller : Enemy_base_controller
{
    public Meduse_controller(string name) : base(name)
    {
        this.Name = name;
        this.HP = 100;
        this.MP = 50;
        this.Damage = 20;
    }

    protected override void Move()
    {
        base.Move();
        // movement realization
    }

    public override void Interact()
    {
        base.Attack();
        // atack realization
    }
}
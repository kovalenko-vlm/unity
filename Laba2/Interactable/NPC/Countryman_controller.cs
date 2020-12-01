using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countryman_controller : NPC_base_controller
{
    public Countryman_controller(string name)
    {
        this.HP = 100;
        this.Sentences = new List<string> { "Good morning, Dr. Freeman", "We need you Dr. Freeman" };
        this.Name = name;
    }

    protected override void Move()
    {
        // рух по заданій локації
    }

    public override void Interact()
    {
        // почати діалог з гравцем
        Speak();
    }
}
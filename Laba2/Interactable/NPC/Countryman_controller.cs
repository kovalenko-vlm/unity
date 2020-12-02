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
        // movement in a given location
    }

    public override void Interact()
    {
        // start a dialogue with player
        Speak();
    }
}
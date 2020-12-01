using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion_of_MP_controller : Item_base_controller
{
    public Potion_of_MP_controller(string name)
    {
        this.Name = name;
        this.Description = "Potion of MP for player";
        this.howManyUse = 1;
    }

    protected override void Use()
    {
        // use potion
    }

    public override void Interact()
    {
        // refill the content of the potion from some items
    }
}
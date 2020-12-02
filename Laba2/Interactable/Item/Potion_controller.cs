using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion_controller : Item_base_controller
{
    public Potion_controller(string name)
    {
        this.Name = name;
        this.Description = "A potion with some unknown effect";
        this.howManyUse = 1;
    }

    protected override void Use()
    {
        // use potion
    }

    public override void Interact()
    {
        // effect realization
    }
}
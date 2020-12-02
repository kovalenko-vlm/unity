using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion_of_heal_controller : Item_base_controller
{
    public Potion_of_heal_controller(string name)
    {
        this.Name = name;
        this.Description = "Potion of heal for player";
        this.howManyUse = 2;
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
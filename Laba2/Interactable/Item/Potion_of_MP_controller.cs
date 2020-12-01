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
        // використати зілля
    }

    public override void Interact()
    {
        // поповнити вміст зілля з певних предметів
    }
}
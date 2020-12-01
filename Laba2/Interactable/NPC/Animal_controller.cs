using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal_controller : NPC_base_controller
{
    public Animal_controller(string name)
    {
        this.HP = 50;
        this.Sentences = new List<string> { "nöff-nöff", "nöff-nöff-nöff-nöff" };
        this.Name = name;
    }

    protected override void Move()
    {
        // рух по заданій локації
    }

    public override void Interact()
    {
        // з певним проміжком в часі подавати певні звуки з набору
        Speak();
    }
}
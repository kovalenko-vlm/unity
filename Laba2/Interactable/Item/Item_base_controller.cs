using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_base_controller : Interactable
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int howManyUse { get; set; }

    protected virtual void Use() 
    { 
        // метод для реалізації використання предмету
    }
}
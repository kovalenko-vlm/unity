using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_base_controller : Interactable
{
    protected string Name { get; set; }
    protected int HP { get; set; }
    protected List<string> Sentences { get; set; }

    protected virtual void Move() 
    { 
        // реалізація руху
    }

    protected virtual void Speak() 
    { 
        // реалізація діалогу
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trader_controller : Countryman_controller
{
    private List<Item_base_controller> itemsList { get; set; }

    public Trader_controller(string name) : base(name)
    {
        this.HP = 100;
        this.Sentences = new List<string> { "Hi!", "I have very interesting things for you!" };
        this.Name = name;
    }

    private void Trade()
    {
        // торгувати з гравцем з списку предметів
    }

    public override void Interact()
    {
        // почати діалог з гравцем
        Speak();
    }
}
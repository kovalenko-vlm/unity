using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_base_controller : Interactable
{
    protected string Name { get; set; }
    protected int HP { get; set; }
    protected int MP { get; set; }
    protected int Damage { get; set; }

    public Enemy_base_controller(string name)
    {
        Name = name;
    }

    protected virtual void Move() 
    {
        // метод для реалізації руху ворога
    }

    public virtual void Attack()
    {
        // метод для реалізації атаки ворога
    }
}
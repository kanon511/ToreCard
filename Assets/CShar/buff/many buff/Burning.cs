using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burning : Buff
{
    float damage = 5;
    override public void Active()
    {
        target.TakeDamage(damage);
    }
    public Burning(Entity target) : base(target) 
    {
        duration = 50;
    }
    
}

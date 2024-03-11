using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regeneration : Buff
{
    float healingAmont=10;
    override public void Active()
    {
        target.Regenerate(healingAmont);
    }
    public Regeneration(Entity target) : base(target)
    {
        duration = 50;
    }
}

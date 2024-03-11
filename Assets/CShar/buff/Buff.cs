using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff
{
    public Entity target;
    public bool lasted = true;
    public int duration = 10;
    public Buff(Entity target)
    {
        this.target = target;
    }

    public void Disappear()
    {
        duration = duration - 1;
        if (duration == 0)
        {
            lasted = false;
        }
    }


    virtual public void Active()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public float maxHitPoint = 20;
    public float hitPoint = 10;
    protected LinkedList<Buff> buffList = new LinkedList<Buff>();
    protected LinkedList<Talent> talentList = new LinkedList<Talent>();
    protected LinkedList<Buff> toBeRemoved = new LinkedList<Buff>();

    protected void Die()
    {
        if (hitPoint <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage(float damage)
    {
        hitPoint -= damage;
    }

    public void Regenerate(float healingAmont)
    {
        if (hitPoint < maxHitPoint) 
        {
            hitPoint += healingAmont;
        }
        else 
        {
            hitPoint = maxHitPoint; 
        }
    }
    public void ActiveBuff()
    {
    
        foreach (Buff i in buffList)
        {
            i.Active();
            i.Disappear();
            if (i.lasted == false)
            {
                toBeRemoved.AddLast(i);
            }
        }


        foreach (Buff i in toBeRemoved)
        {
            buffList.Remove(i);
        }

    }

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

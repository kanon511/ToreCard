using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public Entity entity1;
    public Timer timer;
    public Card()
    {
        timer = new Timer();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(Entity entity, float fireAngle)
    {
        timer.Shoot(entity, fireAngle);
    }

    public void UseCard(Entity entity, Vector3 position)
    {
        Vector3 ms = position;  //鼠标点击的位置
        ms = Camera.main.ScreenToWorldPoint(ms);
        Vector3 es = entity.transform.position; //实体所在的位置
        float fireAngle;
        Vector2 targeDir = ms - es;  //实体与鼠标点击位置的向量
        fireAngle = Vector2.Angle(targeDir, Vector3.up);
        if( ms.x > es.x)
        {
            fireAngle = -fireAngle;
        }
        timer.Shoot(entity, fireAngle);
        Vector3 vector3 = targeDir.normalized;
    }
}

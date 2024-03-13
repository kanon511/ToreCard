using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
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

    public void Shoot(Entity entity, Vector3 vector)
    {
        timer.Shoot(entity, vector);
    }

    public void UseCard(Entity entity, Vector3 position)
    {
        Vector3 ms = position;  //鼠标点击的位置
        ms = Camera.main.ScreenToWorldPoint(ms);
        Vector3 es = entity.transform.position; //实体所在的位置
        Vector3 targeDir = ms - es;  //实体与鼠标点击位置的向量
        targeDir = Camera.main.WorldToScreenPoint(targeDir);
        Vector3 vector3 = targeDir.normalized;
        timer.Shoot(entity, vector3);
    }
}

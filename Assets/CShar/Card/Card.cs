using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Card
{
    public Sprite sprite;
    public SpriteRenderer sr;
    public ShootTime shootTime;
    public Card()
    {
        shootTime = new ShootTime();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UseCard(Entity entity, Vector3 position)
    {
        Vector3 ms = position;  //�������λ��
        ms = Camera.main.ScreenToWorldPoint(ms);
        Vector3 es = entity.transform.position; //ʵ�����ڵ�λ��
        Vector3 targeDir = ms - es;  //ʵ���������λ�õ�����
        targeDir = Camera.main.WorldToScreenPoint(targeDir);
        Vector3 vector3 = targeDir.normalized;
        shootTime.Shoot(entity, vector3);
    }
}

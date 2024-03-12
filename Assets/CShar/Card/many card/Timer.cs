using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    // Start is called before the first frame update
    public float fireRate = 0.5f; // �ӵ���������
    public float nextFire = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(Entity entity, Vector3 vector)
    {
        if (Time.time > nextFire)  // ���ӵ���ʱ����
        {
            nextFire = Time.time + fireRate;  // ��Ϸ����ʱ�䵽���ڵ�ʱ���������ļ��
            Bullet.SummonBullet(entity, 0, entity.transform.position, vector);
        }
    }
}

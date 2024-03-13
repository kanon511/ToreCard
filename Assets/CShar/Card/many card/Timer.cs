using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    // Start is called before the first frame update
    public float fireRate = 0.5f; // 子弹的射击间隔
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
        if (Time.time > nextFire)  // 让子弹有时间间隔
        {
            nextFire = Time.time + fireRate;  // 游戏开发时间到现在的时间加上射击的间隔
            Bullet.SummonBullet(entity, 0, entity.transform.position, vector);
        }
    }
}

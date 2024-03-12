using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D bullets;
    public Vector3 speed;
    public Entity entity;
    public float bulletWallDamage = 10f;     //对墙的子弹伤害
    public float bulletCreatureDamage = 20f; //对生物的子弹伤害

    void Start()
    {
        bullets = GetComponent<Rigidbody2D>();
        bullets.velocity = speed;
        Destroy(gameObject, 3);
    }
    void Update()
    {
        
    }

    public static void SummonBullet(Entity entity ,int bulletId,Vector3 position,Vector3 direction)//生成一个弹射物，参数为：发射实体，弹射物ID，生成位置，发射方向
    {
        GameObject bulletObject = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/Bullet/"+bulletId+".prefab");
        GameObject gb = Instantiate(bulletObject, position, Quaternion.Euler(direction));
        Bullet bullet = gb.GetComponent<Bullet>();
        bullet.entity = entity;
        bullet.speed = direction * 5.0f;
    }

    public void AttackEntity(Entity entity)
    {
        if(entity != null)
         {
             if(entity is Wall)
             {
                 entity.TakeDamage(bulletWallDamage);
             }
             if(entity is Enemy ||  entity is Player)
             {
                 entity.TakeDamage(bulletCreatureDamage);
             }
             Destroy(gameObject);
         }
    }

}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletprefab;
    public Rigidbody2D bullets;
    public float speed = 5.0f;
    public float bulletWallDamage = 10f;     //对墙的子弹伤害
    public float bulletCreatureDamage = 20f; //对生物的子弹伤害

    void Start()
    {
        bullets = GetComponent<Rigidbody2D>();
        bullets.velocity = transform.right * speed;
        Destroy(gameObject, 3);
    }
    void Update()
    {
        
    }

    public static void SummonBullet(int bulletId,Vector3 position,float direction)//生成一个弹射物，参数为：弹射物ID，生成位置，发射方向
    {
        GameObject bullet = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/Bullet/"+bulletId+".prefab");
        Instantiate(bullet, position, Quaternion.Euler(0, 0, direction));
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

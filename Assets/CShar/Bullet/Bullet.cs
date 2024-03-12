using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D bullets;
    public float speed = 5.0f;
    public Entity entity;
    public float bulletWallDamage = 10f;     //��ǽ���ӵ��˺�
    public float bulletCreatureDamage = 20f; //��������ӵ��˺�

    void Start()
    {
        bullets = GetComponent<Rigidbody2D>();
        bullets.velocity = transform.right * speed;
        Destroy(gameObject, 3);
    }
    void Update()
    {
        
    }

    public static void SummonBullet(Entity entity ,int bulletId,Vector3 position,float direction)//����һ�����������Ϊ������ʵ�壬������ID������λ�ã����䷽��
    {
        GameObject bulletObject = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/Bullet/"+bulletId+".prefab");
        GameObject gb = Instantiate(bulletObject, position, Quaternion.Euler(0, 0, direction));
        Bullet bullet = gb.GetComponent<Bullet>();
        bullet.entity = entity;
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

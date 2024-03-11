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
    public int bulletWallDamage = 10;     //��ǽ���ӵ��˺�
    public int bulletCreatureDamage = 20; //��������ӵ��˺�

    void Start()
    {
        bullets = GetComponent<Rigidbody2D>();
        bullets.velocity = transform.right * speed;
        Destroy(gameObject, 3);
    }
    void Update()
    {
        
    }

    public static void SummonBullet(int bulletId,Vector3 position,float direction)//����һ�����������Ϊ��������ID������λ�ã����䷽��
    {
        GameObject bullet = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/Bullet/"+bulletId+".prefab");
        Instantiate(bullet, position, Quaternion.Euler(0, 0, direction));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       Entity entity = collision.gameObject.GetComponent<Entity>();
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

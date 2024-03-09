using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletprefab;
    public Rigidbody2D bullets;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Instantiate(bulletprefab,transform.position,transform.rotation);
        bullets = GetComponent<Rigidbody2D>();
        bullets.velocity = transform.right * speed;
        //Destroy(gameObject, 2);
        SummonBullet(0, Vector3.zero, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)//触碰到别的碰撞器的时候
    {
        Destroy(gameObject);//只要碰撞到碰撞体就摧毁子弹本身
    }

    public static void SummonBullet(int bulletId,Vector3 position,float direction)//生成一个弹射物，参数为：弹射物ID，生成位置，发射方向
    {
        GameObject bullet = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/prefab/Bullet/"+bulletId+".prefab");
        Instantiate(bullet, position, Quaternion.Euler(0, 0, direction));
    }
}

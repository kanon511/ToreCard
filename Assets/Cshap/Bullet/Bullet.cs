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
    private void OnTriggerEnter2D(Collider2D collision)//�����������ײ����ʱ��
    {
        Destroy(gameObject);//ֻҪ��ײ����ײ��ʹݻ��ӵ�����
    }

    public static void SummonBullet(int bulletId,Vector3 position,float direction)//����һ�����������Ϊ��������ID������λ�ã����䷽��
    {
        GameObject bullet = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/prefab/Bullet/"+bulletId+".prefab");
        Instantiate(bullet, position, Quaternion.Euler(0, 0, direction));
    }
}

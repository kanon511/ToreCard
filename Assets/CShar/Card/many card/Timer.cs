using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
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

    public void Shoot(GameObject player)
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time > nextFire)  // ���ӵ���ʱ����
            {
                nextFire = Time.time + fireRate;  // ��Ϸ����ʱ�䵽���ڵ�ʱ���������ļ��
                Bullet.SummonBullet(0, player.transform.position, player.transform.rotation.z);
            }
        }
    }
}

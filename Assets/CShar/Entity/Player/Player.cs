using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity
{
    public float endurance = 200; //�����ǡ���Ӱ������ֵ�Լ������˺�
    public float stength = 200; //��ǿ������Ӱ�������˺�
    public float intelligence = 200; //����������Ӱ�취���˺�
    public float haste = 200; //�����ȡ���Ӱ���ƶ��ٶȺͿ���cd

    
    
    public float speed = 8f;

    private new Rigidbody2D rigidbody;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        Buff buff = new Burning(this);
        buffList.AddLast(buff);
        Buff buff1 = new Regeneration(this);
        buffList.AddLast(buff1);
    }

    

    void Update()
    {
        ActiveBuff();
        Die();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        rigidbody.velocity = context.ReadValue<Vector2>() * speed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity
{
    public float endurance = 200; //“铁骨”，影响生命值以及所受伤害
    public float stength = 200; //“强击”，影响物理伤害
    public float intelligence = 200; //“智力”，影响法术伤害
    public float haste = 200; //“急迫”，影响移动速度和卡牌cd

    
    
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

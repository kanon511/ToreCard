using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity
{
    public float spped = 8f;
    private new Rigidbody2D rigidbody;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Die();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        rigidbody.velocity = context.ReadValue<Vector2>() * spped;
    }
}

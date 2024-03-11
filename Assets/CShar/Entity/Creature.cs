using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public Entity entity;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Bullet bullet = collision.gameObject.GetComponent<Bullet>();
        if (bullet != null)
        {
            bullet.AttackEntity(entity);
        }
    }
}

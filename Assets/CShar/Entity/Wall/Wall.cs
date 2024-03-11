using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : Entity
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bullet bullet = collision.gameObject.GetComponent<Bullet>();
        if (bullet != null)
        {
            TakeDamage(bullet.bulletWallDamage);
        }
    }
    // Start is called before the first frame update
    void Start()
    {   
        hitPoint = 500;
    }

    // Update is called once per frame
    void Update()
    {
        ActiveBuff();
        Die();
    }
}

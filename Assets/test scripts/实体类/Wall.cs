using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : Entity
{
    /*void OnCollisionEnter2D(Collision2D collision)
    {
        bullets bullet = collision.gameObject.GetComponent<bullets>();
        hitpoint -= bullet.damage;
    }*/

        // Start is called before the first frame update
        void Start()
    {   
        hitpoint = 500;
    }

    // Update is called once per frame
    void Update()
    {
        Die();
    }
}

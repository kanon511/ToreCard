using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public float hitpoint = 10;

    /*void OnCollisionEnter2D(Collision2D collision)
    {
            bullets bullet = collision.gameObject.GetComponent<bullets>();
            hitpoint -= bullet.damage;
    }*/
    protected void Die()
    {
        if (hitpoint <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage(float damage)
    {
        hitpoint -= damage;
        print("damaged taken.");
    }

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

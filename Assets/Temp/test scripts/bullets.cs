using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    public float speed=10f;
    int x, y;
    Vector3 direction;
    public float damage = 500f;
   
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        Entity entity = collision.gameObject.GetComponent<Entity>();
        entity.TakeDamage(damage);
    }
        void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        x = -1;
        y = 0;
        direction = new Vector3(x, y, 0);
        myRigidbody.velocity = direction * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

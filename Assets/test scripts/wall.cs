using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float hitpoint;
    void OnCollisionEnter2D(Collision2D collision)
    {
        bullets bullet = collision.gameObject.GetComponent<bullets>();
        hitpoint -= bullet.damage;
    }
    public void takedamage(float damage){
        hitpoint-=damage;
    }
    // Start is called before the first frame update
    void Start()
    {   
        hitpoint = 500;
    }

    // Update is called once per frame
    void Update()
    {
        if (hitpoint<=0){
            Destroy(gameObject);
        }
    }
}

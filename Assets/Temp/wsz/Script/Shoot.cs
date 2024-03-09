using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            GameObject bullet = GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody2D rd = bullet.GetComponent<Rigidbody2D>();
            rd.AddForce(Vector3.up*100);
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    public float speed=10f;
    int x, y;
    Vector3 direction;
    public float damage = 500f;
    void Start()
    {
        x = -1;
        y = 0;
        direction = new Vector3(x, y, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}

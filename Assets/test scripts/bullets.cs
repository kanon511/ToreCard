using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    public float speed=1f;
    int x, y;
    Vector3 direction;
    // Start is called before the first frame update
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

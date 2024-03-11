using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 vectord, vectorw, vectors, vectora;
    void Start()
    {
        vectord = new Vector3(0.01f, 0, 0);
        vectorw = new Vector3(0, 0.01f, 0);
        vectora = new Vector3(-0.01f, 0, 0);
        vectors = new Vector3(0, -0.01f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += vectorw;
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += vectora;
        }
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += vectors;
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += vectord;
        }
    }
}

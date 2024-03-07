using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // transform.Translate(Vector3.left);
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float r = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h/5, r/5, 0));
    }

    
}

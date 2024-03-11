using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float xmove = 0.01f;
    Vector3 div;
    void Start()
    {
        div = new Vector3(xmove, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += div;
    }
}

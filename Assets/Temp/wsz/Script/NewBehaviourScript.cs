using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehavior : MonoBehaviour
{
    public float RotateSpeed = 50f;
    public float DestoryTime = 50f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,DestoryTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector2.up*Time.deltaTime*RotateSpeed,Space.World);
    }
}

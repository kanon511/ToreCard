using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletprefab;
    public Vector3 bullets;
    public Vector3 squares;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Instantiate(bulletprefab,transform.position,transform.rotation);
        bullets = new Vector3(0, 2, 0);
        squares = new Vector3(0, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Instantiate(bulletprefab, bullets, transform.rotation);
            GameObject.Instantiate(bulletprefab, squares, transform.rotation);
        }
    }
}

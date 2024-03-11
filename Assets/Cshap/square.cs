using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour
{
    public GameObject squareprefab;
    public Vector3 squares;
    // Start is called before the first frame update
    void Start()
    {
        squares = new Vector3(0, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(squareprefab, squares, transform.rotation);
        }
    }
}

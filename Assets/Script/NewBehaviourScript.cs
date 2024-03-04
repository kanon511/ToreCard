using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float movespeed = 0.1f;
    private Rigidbody2D myRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
    }
    void Run()
    {
        float moveDir = Input.GetAxis("Horizontal");
        float moveDir2 = Input.GetAxis("Vertical");

        Vector2 playerVel = new Vector2(moveDir2 * movespeed,myRigidbody.velocity.y);
        myRigidbody.velocity = playerVel;
        Vector2 playerVel2 = new Vector2(moveDir * movespeed, myRigidbody.velocity.x);
        myRigidbody.velocity = playerVel2;
    }
}

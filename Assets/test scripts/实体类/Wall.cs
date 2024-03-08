using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : Entity
{
        // Start is called before the first frame update
        void Start()
    {   
        hitpoint = 500;
    }

    // Update is called once per frame
    void Update()
    {
        Die();
    }
}

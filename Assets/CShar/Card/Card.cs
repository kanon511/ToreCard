using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playerShoot(GameObject player)
    {
        Timer timer = new Timer();
        timer.Shoot(player);
    }

    public void UseCard(Entity entity, Vector3 position)
    {

    }
}

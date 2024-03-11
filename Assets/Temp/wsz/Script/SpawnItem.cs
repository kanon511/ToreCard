using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    
    public GameObject Item;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnItems(Vector2 b)
    {
        Vector2 a =new Vector2(Random.Range(-7,-7),Random.Range(4,0));     
        Instantiate(Item, a+b,Quaternion.identity);
    }

}

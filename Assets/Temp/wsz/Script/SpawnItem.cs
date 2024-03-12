using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{

    public List<GameObject> partsLst = new List<GameObject>();
    
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
            int n = partsLst.Count;
        while (n > 0)
        {
            GameObject Item = partsLst[n-1];
            Vector2 a = Random.insideUnitCircle * 4;
            Instantiate(Item, a + b, Quaternion.identity);
            n--;
        }
        Destroy(gameObject);
            
    }

}

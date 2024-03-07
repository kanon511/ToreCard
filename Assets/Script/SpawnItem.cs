using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Item.SummonItem(6, Vector3.zero);//调用Item类的SummonItem方法并传值
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;

public class ChestInteractive : MonoBehaviour,Interactive//调用接口
{
    int n = 0;
    public void Interactive()//重写
    {
          
          SpawnItem test = new SpawnItem();       
          Vector2 a = new Vector2(0f, 0f);
          test = GetComponent<SpawnItem>();
          test.SpawnItems(a);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q)&&n == 0)
        {
            Interactive();
            n++;
        }
    }
}

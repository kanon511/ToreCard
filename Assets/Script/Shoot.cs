using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float r = Input.GetAxis("Vertical");
        if (Input.GetMouseButtonDown(0)) {
            
            GameObject bullet = GameObject.Instantiate(bulletPrefab,new Vector3(h,r,0),transform.rotation);//创建球
           Rigidbody rd =  bullet.GetComponent<Rigidbody>();//获取刚体效果
           //rd.AddForce(Vector3.forward*100);//给100牛的力
           rd.velocity = Vector3.forward * 100;///100m/s
           
        }
    }
}

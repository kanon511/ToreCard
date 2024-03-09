using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)//检测碰撞
    {
        if (collision.gameObject.tag == "Item")//如果碰撞到的物体标签为Item
        {
            Destroy(collision.gameObject);//删除物体
        }
    }
    public static void SummonItem(int itemId, Vector3 position)
    {
        GameObject item = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/Item/" + itemId + ".prefab");//定义item（掉落物）为制定路径上的预制体
        Instantiate(item, position, Quaternion.Euler(0, 0, 0));//在指定位置生成掉落物
    }
}

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
    private void OnTriggerEnter2D(Collider2D collision)//�����ײ
    {
        if (collision.gameObject.tag == "Item")//�����ײ���������ǩΪItem
        {
            Destroy(collision.gameObject);//ɾ������
        }
    }
    public static void SummonItem(int itemId, Vector3 position)
    {
        GameObject item = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/Item/" + itemId + ".prefab");//����item�������Ϊ�ƶ�·���ϵ�Ԥ����
        Instantiate(item, position, Quaternion.Euler(0, 0, 0));//��ָ��λ�����ɵ�����
    }
}

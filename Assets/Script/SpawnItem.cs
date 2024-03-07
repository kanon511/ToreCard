using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public float spawnTime = 2.5f;
    public GameObject Items;// Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnItems", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnItems()
    {
        int spawnIndex = Random.Range(0,SpawnPoints.Length);//���λ�����ɵ�����
        Instantiate(Items, SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);//��ָ��λ�����ɵ�����
    }
    


}

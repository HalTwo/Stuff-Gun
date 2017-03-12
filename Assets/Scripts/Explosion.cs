using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    
    public GameObject MiniBall;
    public GameObject MiniBall2;
    public GameObject MiniBall3;
    public GameObject MiniBall4;
    public GameObject MiniBall5;
    public GameObject MiniBall6;
    public GameObject MiniBall7;
    public GameObject MiniBall8;
   
    public float MinPower = 1f;
    public float MaxPower = 2f;
    public Transform Ball;
    public GameObject pocisk;
    public float timeLeft = 2f;
    public Transform Shard;
    public Transform Shard2;
    public Transform Shard3;
    public Transform Shard4;
    public Transform Shard5;
    public Transform Shard6;
    public Transform Shard7;
    public Transform Shard8;

    void OnTriggerStay()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
            
        {
            Destroy(pocisk);
            
                GameObject spawnedMiniBall = Instantiate(MiniBall, Shard.position, Quaternion.Euler(Shard.eulerAngles)) as GameObject;
                spawnedMiniBall.GetComponent<Rigidbody>().velocity = Shard.right * Random.Range(MinPower, MaxPower);
            

            GameObject spawnedMiniBall2 = Instantiate(MiniBall2, Shard2.position, Quaternion.Euler(Shard2.eulerAngles)) as GameObject;
            spawnedMiniBall2.GetComponent<Rigidbody>().velocity = Shard2.right * Random.Range(MinPower, MaxPower);
            

            GameObject spawnedMiniBall3 = Instantiate(MiniBall3, Shard3.position, Quaternion.Euler(Shard3.eulerAngles)) as GameObject;
            spawnedMiniBall3.GetComponent<Rigidbody>().velocity = Shard3.right * Random.Range(MinPower, MaxPower);
            

            GameObject spawnedMiniBall4 = Instantiate(MiniBall4, Shard4.position, Quaternion.Euler(Shard4.eulerAngles)) as GameObject;
            spawnedMiniBall4.GetComponent<Rigidbody>().velocity = Shard4.right * Random.Range(MinPower, MaxPower);
            

            GameObject spawnedMiniBall5 = Instantiate(MiniBall5, Shard5.position, Quaternion.Euler(Shard5.eulerAngles)) as GameObject;
            spawnedMiniBall5.GetComponent<Rigidbody>().velocity = Shard5.right * Random.Range(MinPower, MaxPower);
            

            GameObject spawnedMiniBall6 = Instantiate(MiniBall6, Shard6.position, Quaternion.Euler(Shard6.eulerAngles)) as GameObject;
            spawnedMiniBall6.GetComponent<Rigidbody>().velocity = Shard6.right * Random.Range(MinPower, MaxPower);
            

            GameObject spawnedMiniBall7 = Instantiate(MiniBall7, Shard7.position, Quaternion.Euler(Shard7.eulerAngles)) as GameObject;
            spawnedMiniBall7.GetComponent<Rigidbody>().velocity = Shard7.right * Random.Range(MinPower, MaxPower);
            

            GameObject spawnedMiniBall8 = Instantiate(MiniBall8, Shard8.position, Quaternion.Euler(Shard8.eulerAngles)) as GameObject;
            spawnedMiniBall8.GetComponent<Rigidbody>().velocity = Shard8.right * Random.Range(MinPower, MaxPower);



        }
    } 
}

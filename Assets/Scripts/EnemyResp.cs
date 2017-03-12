using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyResp : MonoBehaviour {

    public Transform enemy;
    public Transform respawnPoint;

    public float spawnTime = 3.0f;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);

    }

    void Spawn()
    {
        Instantiate(enemy, respawnPoint.position, respawnPoint.rotation);
        //enemy.GetComponent<EnemyAI>().speed += 1;
    }
}

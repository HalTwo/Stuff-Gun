using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
   
    public GameObject Ball;
    public Transform Cannon;
    public float speed = 2f;
    public float ammo = 3;
    public float timeLeft = 60f;
    public float starttime;

    void Start()
    {
        starttime = timeLeft;
    }


    void Update()
    {
        if (ammo < 3)
        {
            starttime -= Time.deltaTime;
            if (starttime < 0)
            {
                starttime = timeLeft;
                ammo += 1;
            }


        }

        if (Input.GetButtonDown("Grenade"))
        {
            if (ammo > 0)
            {

                GameObject spawnedBall = Instantiate(Ball, Cannon.position, Quaternion.Euler(Cannon.eulerAngles)) as GameObject;
                spawnedBall.GetComponent<Rigidbody>().velocity = Cannon.right * speed;
                ammo -= 1;
            } 
        }
    }
}

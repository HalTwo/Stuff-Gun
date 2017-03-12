using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    public float moveSpeed = 150;
    public float power;
    public float ammobullet = 15f;


    public GameObject shoot;
    public Rigidbody enemy; 

    

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        Destroy(gameObject, 2);
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            moveSpeed = 0;
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            //Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }

 

}

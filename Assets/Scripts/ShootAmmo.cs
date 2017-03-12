using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAmmo : MonoBehaviour {

    public float fireRate = 0;
    public float damage;
    public float counter;
    public LayerMask whatToHit;
    public float ammobulletstart = 0;
    

    public Transform BulletPrefab;
    //public GameObject hand;
    public GameObject Enemy;
    //public GameObject CounterText;

    float timeToFire = 0;
    Transform firePoint;

    void Awake()
    {
        counter = 0;                                    //Kill counter 



        firePoint = transform.FindChild("FirePoint");
        if (firePoint == null)
        {
            Debug.LogError("No firepoint !!!!!");
        }

    }

    void Start()
    {
        //BulletPrefab.GetComponent<BulletMove>().ammobullet = ammobulletstart;
    }

    // Update is called once per frame
    void Update()
    {


        if (fireRate == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (ammobulletstart > 0)
                {

                    Shoot();
                    ammobulletstart -= 1;
                }
            }
        }
        else
        {
            if (Input.GetButton("Fire1") && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }

      
    }


    void Shoot()
    {
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, mousePosition - firePointPosition, 100, whatToHit);
        Effect();

        //Debug.DrawLine(firePointPosition, (mousePosition-firePointPosition)*1000, Color.cyan); 

/*
        if (hit.collider.tag == "Enemy")
        {
            //Enemy.GetComponent<Rigidbody2D>().gravityScale = 1;
            //Enemy.GetComponent<Collider2D>().enabled = false;

           // hit.collider.gameObject.GetComponent<Rigidbody>().gravityScale = 1;
            hit.collider.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(hit.collider.gameObject, 1.0f);
            //counter++;
            //CounterText.GetComponent<TextMesh>().text = counter.ToString();
            Debug.Log("hit");
        }*/


    }

    void Effect()
    {
        Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
    }

}

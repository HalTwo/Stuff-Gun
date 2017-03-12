using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour {

    private Vector3 Player;
    private Vector3 PlayerDir;     //Player direction  
    private float Xdif;            //Różnica odległości X
    private float Ydif;            //Różnica odległości Y

    public Rigidbody Enemy;
    public float speed;
    public float starthealth;
    //private float health; 
    public Transform bullet;
    public Image healthbar;
    public float power = 15;


    void Start()
    {
        speed = 10f;
        starthealth = 100f;
    }

    void Update()
    {
        Player = GameObject.Find("Player").transform.position;

        Xdif = Player.x - transform.position.x;                     //różnica pozycji gracza od pozycji wroga
        Ydif = Player.y - transform.position.y;                     //pozwala obliczyć odległość wroga od gracza 

        PlayerDir = new Vector2(Xdif, Ydif);                        //przypisanie różnicy 

        

        Enemy.AddForce(PlayerDir.normalized * speed);

    
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {

            starthealth = starthealth - bullet.GetComponent<BulletMove>().power;
            healthbar.fillAmount = starthealth / 100;
            if (starthealth <= 0f)
            {
                Destroy(gameObject);
            }


        }
    }
}

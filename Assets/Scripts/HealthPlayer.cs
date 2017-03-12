using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour {

    public float hp = 100;
    public float starthealth;
    public Image healthbar;
    public GameObject Enemy;
    public Transform GameOver;
    public GameObject gm;
    void Start()
    {
        starthealth = hp;
    }

    void Update()
    { }
        void OnCollisionEnter(Collision other)
    {
            if (other.gameObject.tag == "Enemy")
            {

                starthealth = starthealth - Enemy.GetComponent<EnemyAI>().power;
                healthbar.fillAmount = starthealth / hp;
                if (starthealth <= 0f)
                {
                    Destroy(gameObject);
                gm.GetComponent<GameManager>().TimeStop();
                GameOver.gameObject.SetActive(true);
                }


            }
        }
    }

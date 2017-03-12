using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour {

    public Transform bullet;
    public GameObject shoot;
    public GameObject health;
    public GameObject BulletPrefab;
    public GameObject Player;
    public GameObject ammocounter;

    void OnMouseOver()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            shoot.GetComponent<ShootAmmo>().BulletPrefab = bullet;
            health.GetComponent<EnemyAI>().bullet = bullet;

            Player.GetComponent<ShootAmmo>().ammobulletstart = BulletPrefab.GetComponent<BulletMove>().ammobullet;
            ammocounter.GetComponent<AmmoCount>().ammocounter = BulletPrefab.GetComponent<BulletMove>().ammobullet;
        }
             
    }
}

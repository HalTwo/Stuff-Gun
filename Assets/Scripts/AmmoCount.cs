using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCount : MonoBehaviour
{

    public float ammocounter = 1;
   private float startAmmoCounter;
    public Image AmmoCounterImage;
    public GameObject Player;

    void Start()
    {
   
    }

    void Update()
   
        {

           startAmmoCounter = ammocounter- Player.GetComponent<ShootAmmo>().ammobulletstart;
            AmmoCounterImage.fillAmount = Player.GetComponent<ShootAmmo>().ammobulletstart / ammocounter;
       


        }
    }
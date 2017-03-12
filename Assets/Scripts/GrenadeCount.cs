using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrenadeCount : MonoBehaviour
{

    public float Grenadecounter = 1;
    // private float startAmmoCounter;
    public Image GrenadeCounterImage;
    public GameObject Grenade;
    public Image GrenadeTimer;
    public float GrenadeTimeLeft = 1;

    void Start()
    {
        Grenadecounter = Grenade.GetComponent<Grenade>().ammo;
        GrenadeTimeLeft = Grenade.GetComponent<Grenade>().timeLeft;
    }
    void Update()

    {

        // startAmmoCounter = ammocounter- Player.GetComponent<ShootAmmo>().ammobulletstart;
        GrenadeCounterImage.fillAmount = Grenade.GetComponent<Grenade>().ammo / Grenadecounter;

        GrenadeTimer.fillAmount = Grenade.GetComponent<Grenade>().starttime / GrenadeTimeLeft;

    }
}
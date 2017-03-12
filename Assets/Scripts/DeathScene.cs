using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScene : MonoBehaviour {

    public GameObject Player;
    public GameObject canvas;

	// Update is called once per frame
	void Update () {
		 if (Player.GetComponent<HealthPlayer>().hp <= 0)
        {
            canvas.gameObject.SetActive(true);
        }
	}
}

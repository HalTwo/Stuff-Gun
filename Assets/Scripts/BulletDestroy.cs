using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour {

    // Use this for initialization
    public GameObject pocisk;
    
      void OnCollisionEnter()

        {
            Destroy(pocisk);
        }
}

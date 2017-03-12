using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas : MonoBehaviour {

    static public canvas instance;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }
}

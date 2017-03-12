using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRot : MonoBehaviour {

    //public int rotationOffset;
    //public float rotZ;
    //public float rotX;

    //public Transform hitPoint;
    public bool direction;
    public Camera cam;
    public int posOffset;
    public GameObject Player; 

    void Start()
    {
        direction = true; 
       
    }

    void Update ()
    {
        //Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //difference.Normalize();

        //rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        //transform.rotation = Quaternion.Euler(rotX, 0f, rotZ + rotationOffset);

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5f;

        Vector3 objectPos = cam.WorldToScreenPoint(transform.position);

        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        if (direction == true) { posOffset = 180;}
        if (direction == false) { posOffset = 180; }

        if (Player.gameObject.transform.rotation == Quaternion.Euler(new Vector3(0f, 180f, 0f)))
        {
            angle = Mathf.Clamp(angle, -70, 30);
            transform.rotation = Quaternion.Euler(new Vector3(-180f, 0, -(angle) + posOffset));
        }

        if (Player.gameObject.transform.rotation == Quaternion.Euler(new Vector3(0f, 0f, 0f)))
        {
            angle = Mathf.Clamp(angle, 130, 200);
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0, angle + posOffset));

        }

        if (angle > 0f && angle < 100f || angle < 0f && angle > -90f)
        {
            if(direction == false)
            {
                direction = true;
                //Flip(); 
            }

        }

        if(angle > 100f && angle < 180f || angle < -90f && angle > -180f)
        {
            if(direction == true)
            {
                direction = false;
                //Flip(); 
            }

        }

    }

}

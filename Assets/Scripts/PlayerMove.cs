using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed;
    public int jump;
    public int jump2;
    public bool ground = false;

    public GameObject hand;
    public Rigidbody Player;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Vector2 moveDir = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Player.velocity.y);
        Player.velocity = moveDir;
     

        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.right = Vector2.left;

            anim.SetBool("Speed", true);
            anim.SetBool("Ground", true);
        }
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.right = Vector2.right;

            anim.SetBool("Speed", true);
            anim.SetBool("Ground", true);
        }
        else
        {
            anim.SetBool("Speed", false);
        }


        if (Player.transform.rotation.y != 0)
        {
            //hand.GetComponent<HandRot>().transform.rotation = Quaternion.Euler(180f, -(hand.GetComponent<HandRot>().rotZ + hand.GetComponent<HandRot>().rotationOffset), hand.GetComponent<HandRot>().transform.rotation.z);
        }


        if (Input.GetKeyDown(KeyCode.W) && ground == true)
        {
            Player.AddForce(new Vector2(0, jump));
            anim.SetBool("Ground", false);
        }
        else
        {
            anim.SetBool("Ground", true);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && ground == true)
        {
            Player.AddForce(new Vector2(0, jump2));
        }
    }


    void OnTriggerStay()
    {
        ground = true;      
    }

    void OnTriggerExit()
    {
        ground = false;
    }


}

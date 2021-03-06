﻿using UnityEngine;
using System.Collections;

public class P1CharacterMove : MonoBehaviour {

    [SerializeField]

    float Speed = 20.0f;

    [SerializeField]

    float jumpSpeed = 5.0f;

    private Rigidbody rb;

    private Vector3 direction;

    private bool grounded;
    
    [SerializeField]
    Transform target; 
   
    // Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    //void Jump()
    //{
    //    rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
    //}

    //void OnCollisionEnter(Collision col)
    //{
    //    if (col.gameObject.name == "Ground")
    //    {
    //        Debug.Log("You are grounded");
    //        grounded = true;
    //        Jump();
            
    //    }
    //    else
    //    {
    //        grounded = false;  
    //    }
    //}

    void Update ()
    {
        transform.LookAt(target);

        direction = Vector3.zero;
        //en avant
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(direction * Speed * Time.deltaTime);
            direction += -Vector3.forward * Time.deltaTime;
        }
            

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(direction * Speed * Time.deltaTime);
            direction = Vector3.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(direction * Speed * Time.deltaTime);
            direction = -Vector3.left * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(direction * Speed * Time.deltaTime);
            direction = Vector3.left * Time.deltaTime;
        }
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Jump();
        //}


      

        
        gameObject.transform.position += direction * Speed * Time.deltaTime;

    }
}

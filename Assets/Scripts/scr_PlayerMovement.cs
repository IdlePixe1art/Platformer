using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;

    public float runSpeed = 40f;
    float HorizontalMove = 0f;
    bool jump = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
	}

    void FixedUpdate()
    {
        //Move the character
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}

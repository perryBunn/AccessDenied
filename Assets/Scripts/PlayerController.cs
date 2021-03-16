using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private playerinput input;
    private Vector3 moveVec;
    private bool jumping = false;
    

    private void Start()
    {
    }

    private void FixedUpdate()
    {
        // 1
        float speedX = Input.GetAxisRaw("Horizontal");  // Left, Right
        float speedY = Input.GetAxisRaw("Vertical");  // Back, Forward
        moveVec = new Vector3(speedX, 0, speedY);
    }

    public void OnMove(InputValue input)
    {
        Vector2 inputVec = input.Get<Vector2>();

        moveVec = new Vector3(inputVec.x, 0, inputVec.y);
    }

    private void OnEnable()
    {
        input.Player.Enable();
    }

    private void OnDisable()
    {
        input.Player.Disable();
    }
}

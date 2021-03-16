using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private playerinput input;

    private Vector2 currentMove;
    private bool movePressed;
    private bool runPressed;

    private void Awake()
    {
        input = new playerinput();

        input.Player.Move.performed += ctx =>
        {
            currentMove = ctx.ReadValue<Vector2>();
            movePressed = currentMove.x != 0 || currentMove.y != 0;
        };
        input.Player.Move.performed += ctx => Debug.Log(ctx.ReadValueAsObject());
    }

    private void Start()
    {
    }

    private void Update()
    {
        handleMovement();
    }

    void handleMovement()
    {
        if (movePressed)
        {
            Debug.Log("Movement");
        }
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

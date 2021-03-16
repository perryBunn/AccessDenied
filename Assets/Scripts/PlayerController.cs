using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionAsset playerControls;
    public GameObject Player;
    public Rigidbody PlayeRigidbody;
    public int playerspeed;
    
    private InputAction movement;
    private InputAction fire;
    
 
    private void Awake()
    {
        var gameplayActionMap = playerControls.FindActionMap("Player");
 
        movement = gameplayActionMap.FindAction("Move");
        movement.performed += OnMove;
        movement.canceled += OnMove;
        movement.Enable();
    }

    private void Start()
    {
        PlayeRigidbody = Player.GetComponent<Rigidbody>();
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
 
        // Code that moves the player based on the direction
        var playermov = new Vector3(direction.x, 0f, direction.y);
        PlayeRigidbody.MovePosition(PlayeRigidbody.position + playermov * playerspeed * Time.fixedDeltaTime);
        // Player.transform.position += playermov;
    }
    
}

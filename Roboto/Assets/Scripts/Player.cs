using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/*This script handles all controllable actions by the player. */

public class Player : Robot
{
    public Rigidbody rb;
    public float baseMoveSpeed {get;} = 10f;
    public float moveSpeed;
    Vector3 moveDirection;

    [Header("Inputs")]
    public PlayerInput playerControls;
    InputAction move;
    InputAction fireWeapon;


    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = baseMoveSpeed;
    }

   
    void OnEnable()
    {
        move = playerControls.Player.Movement;
        move.Enable();


        fireWeapon = playerControls.Player.FireWeapon;
        fireWeapon.Enable();
        fireWeapon.performed += FireWeapon;     //calls the FireWeapon method in this script
    }

    void OnDisable()
    {
        move.Disable();
        fireWeapon.Disable();
    }

    //FixedUpdate is for any physics involving rigidbodies. Player movement and possibly other actions go in here.
    void FixedUpdate()
    {

    }

    void Update()
    {
        
    }

    #region Controls
    public void MoveForward(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            //move player forward
            Debug.Log("moved forward");
        }
    }

    public void MoveBackward(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            //move player back
           Debug.Log("moved back");
        }
        
    }

    public void MoveLeft(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            //move player left
            Debug.Log("moved left");
        }

    }

    public void MoveRight(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            //move player right
            Debug.Log("moved right");
        }
       
    }

    public void FireWeapon(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            //shoot equipped weapon
            Debug.Log("fire!");
        }

    }

    #endregion
}

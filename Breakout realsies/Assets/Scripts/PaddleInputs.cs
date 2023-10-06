using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PaddleInputs : MonoBehaviour
{
    private Rigidbody rigidBody;
    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();
        rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector2 moveVec = playerInputActions.Player.Move.ReadValue<Vector2>();
        transform.Translate(new Vector3(moveVec.x, 0, moveVec.y) * 0.2f);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 mobveVec = context.ReadValue<Vector2>();
        transform.Translate(new Vector3(moveVec.x, 0, moveVec.y) * 0.2f);
    }
    
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour, Controls.IPlayerActions
{
    //create a instance of controls
    private Controls controls;
    public event Action JumpEvent;
    public event Action DodgeEvent;
    public Vector2 MovementValue { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        controls.Player.SetCallbacks(this);
        // enable the controls
        controls.Player.Enable();
    }

    void OnDestroy()
    {
        // disable the controls
        controls.Player.Disable();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        // see when the button is pressed
        if (!context.performed) return;
        JumpEvent?.Invoke();
    }

    public void OnDodge(InputAction.CallbackContext context)
    {
        // see when the button is pressed
        if (!context.performed) return;
        DodgeEvent?.Invoke();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        MovementValue = context.ReadValue<Vector2>();
    }
}

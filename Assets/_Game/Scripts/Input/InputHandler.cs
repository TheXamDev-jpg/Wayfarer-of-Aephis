using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private InputSystem_Actions _inputSystemActions;
    public event Action<Vector2> TouchStarted;
    public event Action<Vector2> TouchEnded;s
    public Vector2 TouchStartPosition { get; private set; }
    public Vector2 TouchCurrentPosition { get; private set; }
    public bool TouchHeld {  get; private set; } = false;
}

private void Awake()
{
    _inputSystemsActions = new InputSystem_Actions();
}

private void OnEnable()
{
    _inputSystemActions.Enable();
    _inputSystemActions.Player.TouchPoint.performed += OnTouchPerformed;
    _inputSystemActions.Player.TouchPoint.canceled += OnTouchCancelled;
}
private void OnDisable()
{
    _inputSystemActions.Player.TouchPoint.performed += OnTouchPerformed;
    _inputSystemActions.Player.TouchPoint.canceled += OnTouchCancelled;
    _inputSystemActions.Disable();
}

private void OnTouchPerformed(InputAction.CallbackContext context)
{
    Debug.Log("Touch");
    TouchHeld = true;
    Vector2 TouchPosition = context.ReadValue<Vector2>();

}

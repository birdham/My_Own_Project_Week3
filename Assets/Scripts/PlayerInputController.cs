using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }
    
    public void OnMove(InputValue value)
    {
        Vector2 moveinput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveinput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldsPos = _camera.ScreenToWorldPoint(newAim);
        Vector2 direction = (worldsPos - (Vector2)transform.position);

        if (direction.magnitude >= 0f)
        {
            CallLookEvent(direction);
        }
    }
}

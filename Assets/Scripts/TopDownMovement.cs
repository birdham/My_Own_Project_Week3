using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController movementController;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        movementController = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        movementController.OnMoveEvent += Move;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }
    
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        movementRigidbody.velocity = direction;
    }
}

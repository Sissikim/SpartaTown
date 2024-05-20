using System;
using UnityEngine;

public class SpartaTownMovement : MonoBehaviour
{
    private SpartaTownController controller;
    private Rigidbody2D movementRigidbody;
    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<SpartaTownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        if (controller != null)
        {
            controller.OnMoveEvent += Move;
        }
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }
}

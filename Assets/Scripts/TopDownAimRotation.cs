using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class TopDownAimRotation : MonoBehaviour
{
    private TopDownController _controller;

    [SerializeField] private SpriteRenderer characterRenderer;

    private void Awake()
    {
        _controller = GetComponent<TopDownController>();
    }
    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }

}

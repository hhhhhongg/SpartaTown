using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer Renderer;

    [SerializeField] private SpriteRenderer characterRenderer;

    private CharacterController _controller;
    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
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
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Renderer.flipY = Mathf.Abs(rotZ) > 90f;
        characterRenderer.flipX = Renderer.flipY;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

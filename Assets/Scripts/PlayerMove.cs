using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator Animator;
    private float _speed = 10;
    private float _jumpForce = 8;
    private float _moveInput;
    private Rigidbody2D _rb;
    private SpriteRenderer _playerSpriteRenderer;
    private bool _isGrounded;
    public Transform GroundCheck;
    public float CheckRadius;

    public LayerMask WhatIsGround;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _playerSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _isGrounded = Physics2D.OverlapCircle(GroundCheck.position, CheckRadius, WhatIsGround);
        _moveInput = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(_moveInput * _speed, _rb.velocity.y);
        _playerSpriteRenderer.flipX = !(_moveInput > 0);
    }

    void Update()
    {
        Animator.SetFloat("Speed",Mathf.Abs(_moveInput));
        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _rb.velocity = Vector2.up * _jumpForce;
        }
    }
}
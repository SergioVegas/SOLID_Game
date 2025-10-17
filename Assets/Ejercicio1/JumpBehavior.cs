using System;
using UnityEngine;

public class JumpBehavior : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float jumpForce = 10f;
    private float _nextJumpTime = 0f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    public void Jump(float timeJump)
    {
        if (Time.time >= _nextJumpTime)
        {
            _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, jumpForce*3);
            //Debug.Log("Jump" + gameObject.name);
            _nextJumpTime = Time.time + timeJump;
        }
    }
}
    

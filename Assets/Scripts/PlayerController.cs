using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
#pragma warning disable


public class PlayerController : MonoBehaviour
{
    public float speed = 7;
    private float _moveHorizontal;
    private float _moveVertical;
    private Vector3 _movement;
    private Rigidbody _rb;

    
    private void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    
    //Das Movement wird über AddForce auf das Player RigidBody ausgeübt
    //für ein smoothes Movement muss im RB das "Interpolate" auf Interpolate geändert werden
    private void FixedUpdate()
    { 
        _moveHorizontal = Input.GetAxis("Horizontal");
        _moveVertical = Input.GetAxis("Vertical");
        
        _movement = new Vector3(_moveHorizontal, 0, _moveVertical);

        _rb.AddForce(_movement * speed);
    }
}

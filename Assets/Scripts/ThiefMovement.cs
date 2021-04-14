using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefMovement : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private  Transform _endPoint;
    [SerializeField] private float _speed;

    private bool _houeIsRobbed;

    private void FixedUpdate()
    {
        if (_houeIsRobbed==false)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed*Time.deltaTime);  
       }
       else
        {
            transform.position = Vector3.MoveTowards(transform.position, _endPoint.position, _speed*Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.TryGetComponent<Chest>(out Chest chest))
        {
            _houeIsRobbed = true;
        }
    }
}

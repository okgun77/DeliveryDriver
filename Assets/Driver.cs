using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed   = 1f;
    [SerializeField] private float moveSpeed    = 20f;
    [SerializeField] private float slowSpeed    = 15f;
    [SerializeField] private float boostSpeed   = 30f;

    
    private void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") *steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D _collision)
    {
        moveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D _collision)
    {
        if (_collision.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
}

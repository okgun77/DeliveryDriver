using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed   = 0.1f;
    [SerializeField] private float moveSpeed    = 0.01f;

    
    private void Start()
    {
        
    }

    
    private void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") *steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement
{
    [SerializeField] private float rotationSpeed;
    
    protected override void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Rotate(new Vector3(0, horizontal * Time.deltaTime * rotationSpeed, 0));
        Vector3 direction = new Vector3(transform.forward.x * vertical, 0, transform.forward.z * vertical);
        rb.velocity = new Vector3(direction.x * speed, rb.velocity.y, direction.z * speed);
    }
}

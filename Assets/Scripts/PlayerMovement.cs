using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    
    void Awake()
    {
        rb =GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        /*
        if (horizontal != 0 || vertical != 0)
        {
            transform.forward = new Vector3(horizontal, 0, vertical);
        }
        rb.velocity=new Vector3(horizontal*speed, rb.velocity.y, vertical*speed);
        return;
        */
        transform.Rotate(new Vector3(0, horizontal * Time.deltaTime * rotationSpeed, 0));
        Vector3 direction = new Vector3(transform.forward.x * vertical, 0, transform.forward.z * vertical);
        rb.velocity = new Vector3(direction.x * speed, rb.velocity.y, direction.z * speed);
    }
}

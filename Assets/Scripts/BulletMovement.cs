using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    private Vector3 direction;

    public void SetDirection(Vector3 direction)
    {
        this.direction = direction;
    }
    
    void Awake()
    {
        rb=GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        rb.velocity = direction * speed;
    }
}

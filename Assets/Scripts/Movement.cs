using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    protected Rigidbody rb;
    [SerializeField] protected float speed;

    private void Awake()
    {
        Initialize();   
    }

    protected virtual void Initialize()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    protected virtual void Move()
    {

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeMovement : EnemyMovement
{
    private Transform targetTransform;

    void Start()
    {
        targetTransform = GameObject.Find("Player").transform;
    }

    protected override void Move()
    {
        Vector3 direction = targetTransform.position - transform.position;
        direction.y = 0;
        direction = direction.normalized;
        direction = direction * speed;
        direction.y = rb.velocity.y;
        rb.velocity = direction;
    }


}

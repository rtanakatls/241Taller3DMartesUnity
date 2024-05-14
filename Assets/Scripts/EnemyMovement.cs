using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : Movement
{
    protected override void Move()
    {
        Vector3 move = transform.forward * speed;
        move.y = rb.velocity.y;
        rb.velocity = move ;
    }
}

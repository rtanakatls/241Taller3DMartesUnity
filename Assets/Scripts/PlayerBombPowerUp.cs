using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBombPowerUp : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private float radius;

    private void Update()
    {
        Explode();
    }

    private void Explode()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, radius, layerMask);
            foreach (var hit in colliders)
            {
                hit.GetComponent<EnemyLife>().ChangeLife(-10);                
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}

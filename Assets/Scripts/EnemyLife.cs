using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : LifeController
{

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(collision.gameObject);
            ChangeLife(-collision.gameObject.GetComponent<DamageController>().GetDamage());
        }
    }
}

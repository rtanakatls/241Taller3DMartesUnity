using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeLife : EnemyLife
{
    private bool specialAbilityActivated;
    public override void ChangeLife(int value)
    {

        life += value;
        if(life<=0 && !specialAbilityActivated)
        {
            life = 1;
            specialAbilityActivated = true;
        }
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}

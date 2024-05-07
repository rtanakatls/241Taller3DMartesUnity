using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] protected int damage;

    public int GetDamage()
    {
        return damage;
    }
}

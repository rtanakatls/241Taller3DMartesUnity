using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] protected int life;

    public virtual void ChangeLife(int value)
    {
        life += value;
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }
}

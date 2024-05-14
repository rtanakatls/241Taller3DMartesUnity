using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class EnemyPattern 
{
    [SerializeField] private List<GameObject> enemyPrefabs;

    public List<GameObject> EnemyPrefabs
    {
        get
        {
            return enemyPrefabs;
        }
    }
}

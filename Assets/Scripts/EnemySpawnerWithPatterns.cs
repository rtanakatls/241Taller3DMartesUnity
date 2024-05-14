using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerWithPatterns : MonoBehaviour
{
    [SerializeField] private List<GameObject> currentPattern;
    [SerializeField] private List<EnemyPattern> enemyPatterns;

    private float timer;
    private int index;

    private void Awake()
    {
        currentPattern= enemyPatterns[Random.Range(0, enemyPatterns.Count)].EnemyPrefabs;
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            GameObject obj = Instantiate(currentPattern[index]);
            obj.transform.position = transform.position;
            index++;
            if (index >= currentPattern.Count)
            {
                index = 0;
            }
            timer = 0;

        }
    }
}

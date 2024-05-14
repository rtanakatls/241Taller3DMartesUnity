using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemyPrefabs;
    private float timer;



    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            GameObject obj = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Count)]);
            obj.transform.position = transform.position;
            timer = 0;
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerWithNumbers : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemyPrefabs;

    private int[] currentPattern;
    private int[] pattern1 = { 0, 1 };
    private int[] pattern2 = { 0,0,1 };
    private int[] pattern3 = { 0,0,0 };


    private float timer;
    private int currentPatternNumber;
    private int index;

    private void Awake()
    {
        currentPatternNumber = Random.Range(1,4);
        switch (currentPatternNumber)
        {
            case 1:
                currentPattern= pattern1;
                break;
            case 2:
                currentPattern = pattern2;
                break;
            case 3:
                currentPattern = pattern3;
                break;
        }
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            int enemyIndex = currentPattern[index];
            GameObject obj = Instantiate(enemyPrefabs[enemyIndex]);
            obj.transform.position = transform.position;
            index++;
            if (index >= currentPattern.Length)
            {
                index = 0;
            }
            timer = 0;

        }
    }
}

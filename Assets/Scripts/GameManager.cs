using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> groundPrefabs;
    private int[,] currentPattern;
    private int[,] pattern1 = {
        { 0, 0,0 },
        { 1, 1,1 } ,
        {2,2,2 }
    };
    private int[,] pattern2 = {
        { 0, 1,2 },
        { 1, 2,0 } ,
        {2,0,1 }
    };

    void Start()
    {
        int currentPatternNumber = Random.Range(1, 3);
        switch (currentPatternNumber)
        {
            case 1:
                currentPattern = pattern1;
                break;
            case 2:
                currentPattern = pattern2;
                break;
        }
        for (int i = 0; i < currentPattern.GetLength(0); i++)
        {
            for (int j = 0; j < currentPattern.GetLength(1); j++)
            {
                GameObject obj = Instantiate(groundPrefabs[currentPattern[i, j]]);
                obj.transform.position = new Vector3(i * 10, -2, j * 10);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

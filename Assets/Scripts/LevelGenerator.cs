using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Transform Enemy_1;
    public Transform Enemy_2;
    public Transform Enemy_3;

   private void Awake()
    {
        for(int i = 0; i < Random.Range(3,8); i++)
        {
            generateEnemy(RandomEnemy(Random.Range(1,4)));
        }
    }

    private void generateEnemy(Transform enemyTransform)
    {
        Instantiate(enemyTransform, new Vector3(Random.Range(-6, 8), -0.5f), Quaternion.identity);
    }

    public Transform RandomEnemy(int enemyNumber)
    {
        switch(enemyNumber)
        {
            case 1:
                return Enemy_1;
                break;
            case 2:
                return Enemy_2;
                break;
            case 3:
                return Enemy_3;
                break;
            default:
                return Enemy_1;     
        }    
    }
}

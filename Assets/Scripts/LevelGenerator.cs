using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
   // public static Random rand = new Random();
    //public static int randXPos = rand.Next(0, 4);
    public Transform Enemy_1;
   private void Awake()
    {
        Instantiate(Enemy_1, new Vector3(2, -0.5f), Quaternion.identity);
    }

}

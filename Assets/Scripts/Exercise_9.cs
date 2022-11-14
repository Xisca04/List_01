using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_9 : MonoBehaviour
{
    //Candy division

    public int candy = 20;
    public int children = 3;
    private int result;

    private void Start()
    {
        result = candy / children;
        Debug.Log($"Each child gets {result} candies.");

        result = candy % children;
        Debug.Log($"{result} candy left over");
    }
}

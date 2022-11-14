using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_1 : MonoBehaviour
{
    //Sum 3 float

    public float num1 = 5f;
    public float num2 = 10f;
    public float num3 = 2f;

    private float result;

    private void Start()
    {
        result = num1 + num2 + num3;

        Debug.Log($"The result of the sum is {result}.");
    }
}

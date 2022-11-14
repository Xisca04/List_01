using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_10 : MonoBehaviour
{
    //The multiplication table of 2

    public int number = 2;
    private int result;
    private int num2 = 1;
    private int result1;
    private int num3 = 2;
    private int result2;
    private int num4 = 3;
    private int result3;
    private int num5 = 4;
    private int result4;
    private int num6 = 5;
    private int result5;
    private int num7 = 6;
    private int result6;
    private int num8 = 7;
    private int result7;
    private int num9 = 8;
    private int result8;
    private int num10 = 9;
    private int result9;
    private int num11 = 10;
    

    private void Start()
    {
        result = number * num2;
        {
            Debug.Log($"{number} x 1 = {result}");
        }

        result1 = number * num3;
        {
            Debug.Log($"{number} x 2 = {result1}");
        }

        result2 = number * num4;
        {
            Debug.Log($"{number} x 3 = {result2}");
        }

        result3 = number * num5;
        {
            Debug.Log($"{number} x 4 = {result3}");
        }

        result4 = number * num6;
        {
            Debug.Log($"{number} x 5 = {result4}");
        }
        result5 = number * num7;
        {
            Debug.Log($"{number} x 6 = {result5}");
        }
        result6 = number * num8;
        {
            Debug.Log($"{number} x 7 = {result6}");
        }
        result7 = number * num9;
        {
            Debug.Log($"{number} x 8 = {result7}");
        }
        result8 = number * num10;
        {
            Debug.Log($"{number} x 9 = {result8}");
        }
        result9 = number * num11;
        {
            Debug.Log($"{number} x 10 = {result9}");
        }
    }


}

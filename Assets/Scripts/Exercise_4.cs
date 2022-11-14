using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_4 : MonoBehaviour
{
    //Birthday and currentage

    public int birthYear = 2004;
    public int currentage = 2022;
    private int result;

    public int age = 18;

    private void Start()
    {
        result = currentage - birthYear;
        Debug.Log($"The result of the subtraction is {result}.");

        Debug.Log($"If we are in the year {currentage} and you were born in {birthYear}, you are {result} years old.");

        Debug.Log($"You are {age} years old.");
    }
}

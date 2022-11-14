using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_3 : MonoBehaviour
{
    //Age and name

    public string personName = "Xisca";
    public int age = 18;

    private void Start()
    {
        Debug.Log($"Hello {personName}, you are {age} years old.");
    }
}

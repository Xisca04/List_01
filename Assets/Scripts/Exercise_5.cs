using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_5 : MonoBehaviour
{
    //variable is greater

    public int x = 10;
    public int y = 5;
    private bool isGreater;

    private void Start()
    {
        isGreater = x > y;
        Debug.Log(isGreater);
    }
}

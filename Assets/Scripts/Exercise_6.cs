using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_6 : MonoBehaviour
{
    //Days of the weekend-operation

    public int numbers;

    private void Start()
    {
        if (numbers >= 6)
        {
            Debug.Log($"This day, {numbers}, belongs to the weekend.");
        }
        else
        {
            Debug.Log($"This day, {numbers}, does not belong to the weekend.");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_2 : MonoBehaviour
{
    //Name and city

    public string personName = "Xisca";
    public string Cityname = "Plama";

    private void Start()
    {
        Debug.Log($"Hello {personName}, welcome to {Cityname}!");
    }
}

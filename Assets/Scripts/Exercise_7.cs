using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_7 : MonoBehaviour
{
    // vowel or consonant

    public string letter;

    private void Start()
    {
        if (letter == ("a,e,i,o,u"))
        {
            Debug.Log($"This letter, {letter}, is a vowel.");
        }
        else
        {
            Debug.Log($"This letter, {letter}, is a consonant.");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise07 : MonoBehaviour
{
    public string letra;
    void Start()
    {
        if(letra == "a"|| letra == "e" || letra == "i" || letra == "o" || letra == "u")
        {
            Debug.Log(message: $"{letra} is a vowel");
        }
        else
        {
            Debug.Log(message: $"{letra} is a consonant");
        }
    }
}
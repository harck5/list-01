using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise02 : MonoBehaviour
{

    public string name;
    public string city;
    void Start()
    {
        Debug.Log(message: $"Hello, {name}! Welcome to {city}");
    }

}
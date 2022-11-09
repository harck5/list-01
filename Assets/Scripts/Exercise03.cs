using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    public int age;
    public string name;

    void Start()
    {
        Debug.Log(message: $"Hello, {name}! You are {age} years old.");
    }

}
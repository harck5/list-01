using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise04 : MonoBehaviour
{

    public int currentYear;
    public int birthYear;
    public int age;
    void Start()
    {
        Debug.Log(message: $"If we are in the year {currentYear} and you were born in {birthYear}, you are {age} years old.");
    }

    void Update()
    {

    }
}
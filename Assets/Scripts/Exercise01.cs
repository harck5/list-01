using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    public float num1;
    public float num2;
    public float num3;


    void Start()
    {
        Debug.Log(message: $"{num1} + {num2} + {num3} = {num1 + num2 + num3}");
    }
}
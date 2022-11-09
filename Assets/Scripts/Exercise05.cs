using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise05 : MonoBehaviour
{

    public int x;
    public int y;
    public bool isGreater;
    void Start()
    {
        //isGreater = x > y;
        if (isGreater = x > y)
        {
            Debug.Log(message: $"{x} is greater than {y}");

        }
        //isGreater = x < y;
        if (isGreater = x < y)
        {
            Debug.Log(message: $"{x} is less than {y}");
        }
        if (isGreater = x == y)
        {
            Debug.Log(message: $"{x} is equal to {y}");
        }
    }

    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise06 : MonoBehaviour
{
    public int day;

    void Start()
    {
        if (day < 6)
        {
            Debug.Log(message: $"Day {day} does not belong to the weekend");
        }
        if (day == 6)
        {
            Debug.Log(message: $"Day {day} belongs to the weekend");
        }
        if (day == 7)
        {
            Debug.Log(message: $"Day {day} belongs to the weekend");
        }
        if (day > 7)
        {
            Debug.Log(message: $"The week don't have more days");
        }
    }
}
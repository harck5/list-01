using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise08 : MonoBehaviour
{
    public string mes;
    void Start()
    {
        if (mes == "January" || mes == "March" || mes == "May" || mes == "July" || mes == "August" || mes == "Octuber" || mes == "December")
        {
            Debug.Log(message: $"{mes} ends on the 31st");
        }
        if (mes == "April" || mes == "June" || mes == "September" || mes == "November")
        {
            Debug.Log(message: $"{mes} ends on the 30st");
        }
        if (mes == "February")
        {
            Debug.Log(message: $"{mes} ends on the 28st");
        }
    }
}

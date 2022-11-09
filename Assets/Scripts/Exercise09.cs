using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise09 : MonoBehaviour
{
    public int dulces;
    public int personas;
        
    void Start()
    {
        Debug.Log(message:$"Each person takes {dulces / personas} candies and {dulces % personas} candies are left over");
    }
}

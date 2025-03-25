using System;
using System.Linq;
using UnityEngine;

class MinValueFinder : MonoBehaviour
{
    void Start()
    {
        int[] numbers = { -2, -5, -3, -7, -1 };
        int minValue = numbers.Min();
        Debug.Log("최소값은 " + minValue + " ");
    }
}
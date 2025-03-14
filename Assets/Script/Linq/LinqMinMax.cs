using System.Linq;
using UnityEngine;
using System.Collections.Generic;
public class LinqMinMax : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = { 1, 2, 3 };

        int max = 0;
        int min = 0;

        max = numbers.Max();
        min = numbers.Min();

        Debug.Log($"numbers의 최대값 : {max}, 최소값 : {min}");

    }
}

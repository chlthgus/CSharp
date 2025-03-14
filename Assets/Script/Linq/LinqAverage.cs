using System.Linq;
using UnityEngine;

public class LinqAverage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = { 1, 2, 5 };

        double average = numbers.Average();
        Debug.Log($"numbers 배열 요소들의 평균값은{average:#.##}");
    }
}

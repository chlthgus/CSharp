using System.Linq;
using UnityEngine;

public class LinqCount : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = { 1, 2, 3 };

        int count = numbers.Count();
        Debug.Log($"numbers배열의 갯수는 {count}");
    }
}

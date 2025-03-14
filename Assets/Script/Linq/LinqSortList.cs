using UnityEngine;
using System.Collections.Generic;
using System.Linq;
public class LinqSortList : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<string> colors = new List<string> { "Red" , "Green" , "Blue" };

        var sortedColors = colors.OrderByDescending(c => c);

        foreach (var color in sortedColors)
        {
            Debug.Log(color);
        }


    }
}

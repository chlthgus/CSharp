using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListOfString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]<string>
        List<string> colors = new List<string>();

        //[2] 리스트에 데이터 넣기
        colors.Add("Red");
        colors.Add("Gerrn");
        colors.Add("Blue");

        //[3]리스트에서 데이터 꺼내기
        foreach (var s in colors)
        {
            Debug.Log(s);
        }
    }
}

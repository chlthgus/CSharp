using UnityEngine;

public class StringClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "Hello";
        System.String s2 = "반갑습니다";

        Debug.Log($"{s1}길이: {s1.Length} , {s2}길이: {s2.Length}");

        //길이
    }
}

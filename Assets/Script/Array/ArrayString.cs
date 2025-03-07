using UnityEngine;

public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string arr = "c#8";

        Debug.Log(arr[0]);  //C
        Debug.Log(arr[1]);  //#
        Debug.Log(arr[2]);  //8
    }
}

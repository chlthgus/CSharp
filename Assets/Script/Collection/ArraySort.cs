using UnityEngine;

//Sort(����)
public class ArraySort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arr = { 3, 2, 1, 4, 5 };
        
        for (int i = 0; i<arr.Length; i++)
        {
            Debug.Log(arr[i]);

        }
        Debug.Log("=============");


        //sort - �������� ����
        System.Array.Sort(arr);

        foreach(var num in arr)
        {
            Debug.Log("=============");

            //Reverse - �迭�� ���� ����
            System.Array.Reverse(arr);


        }    

    }
}

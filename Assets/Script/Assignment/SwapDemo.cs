using System;
using UnityEngine;

//
public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;
        int temp;

        Debug.Log($"ó������ i:{i}, j:{j}");

        //�ڸ� �ٲٱ�
        temp = i; //�ӽú���(temp)�� i�� ����
        i = j;  //i������ j�� ����
        j = temp;   //j������ �ӽú���(temp)�� ����Ǿ���i���� ����

        Debug.Log($"���� �� i:{i}, j:{j}");




        // (i, j) = (j, i);

        //  Console.WriteLine($"ó�� i : {i} , j : {j}");

        //  (i, j) = (j, i);
        //  Console.WriteLine($"���� i : {i} , j : {j}");

        //  Debug.Log(i);
        //  Debug.Log(j);


    }
}

/*
 [Q]
+,-,*,/ ���� ������� ���� I�� J�� ���� ���� �ٲپ �����ϼ���
=�� �̿��ϼ���
 
 [output]
ó�� i : 100 , j : 200
���� i : 200 , j : 100
 */
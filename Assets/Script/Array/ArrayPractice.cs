using System;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //3�� 3���� 2���� �迭�� �����
        int[,] arr = new int[3, 3];

        //�� �ʱ�ȭ, ��� ���� �ε��� ������ 1, ��� ���� �ε����� Ʋ���� 0
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j) //��� ���� �ε��� ������
                {
                    arr[i, j] = 1;
                }
                else //��� ���� �ε����� Ʋ����0
                {
                    arr[i, j] = 0;
                }
            }
        }
    }
}
            
        






            /*
            int[,] arr = new int[3, 3];

        // �迭 �� �ʱ�ȭ
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                    arr[i, j] = 1;
                else
                    arr[i, j] = 0;
            }
        }

        // �迭 ���
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"arr[{i},{j}] : {arr[i, j]}");
            }
        }
    }
}*/


/*
[Q]
3�� 3���� 2���� �迭�� �����
�迭�� ���� ��� ���� �ε��� ������ 1, ��� ���� �ε����� Ʋ���� 0���� �����ϼ���

1,0,0
0,1,0
0,0,1

[output]
arr[0,0] :1
arr[0,1] :0
....
arr[2,2] :1

 
 */
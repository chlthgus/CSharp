using UnityEngine;

//�ζ� ��ȣ ������
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Random
        System.Random rand = new System.Random();

        int[] numbers = new int[6];



        for (int i = 0; i <6; i++)
        {
            numbers[i] = rand.Next(1, 46);
        }


    }
}

/*
 
 [Q]
�ζ� ��ȣ ������ �����
[1] 6�� ��ȣ
[2] 1~45�� ������ ���� ��ȣ
[3] �ߺ��� ���ڰ� ������ �ȵȴ�


[1], [2] ���� ����

[output] - ���ǿ� �´� ��ȣ 6�� ���
 
 
 */
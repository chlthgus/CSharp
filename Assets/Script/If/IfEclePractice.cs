using UnityEngine;

public class IfEclePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        int score = 85;
        int g = 90;
        int s = 80;
        int u = 70;
        int f = 0;



        
        if(g > score)
        {
            Debug.Log("�ݸ޴��� �����Ͽ����ϴ�");
        }

        if (s > score)
        {
            Debug.Log("���޴��� �����Ͽ����ϴ�");
        }

        if (u > score)
        {
            Debug.Log("���޴��� �����Ͽ����ϴ�");
        }

        if (f > score)
        {
            Debug.Log(" ");
        }

    }
}

/*
 
[Q]
score�� 90�̻��̸� �ݸ޴� ���, 80�̻��̸� ���޴� ���
70�̻��̸� ���޴� ���, �׿� �������� ��޴� ���
score�� 85��

[output]
()�޴��� �����Ͽ����ϴ�
 
 
 */
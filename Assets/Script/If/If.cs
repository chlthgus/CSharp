using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//���� score�� 60�� �̻��̸� "�հ�"�̶�� ���,
//score 61�� 

public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
         if (Score�� 60�� �̻�)
             {

             "�հ�" �̶�� ���
         }
        */


        int score = 61;

        if (score >= 60)    //���ǹ��� ���̸� ���{}�ȿ� �ִ� ���๮�� ����
        {
            //���๮
            Debug.Log("�հ�");
        }


    }
}

/*
 
 if�� - ���ǹ�
���ǽ��� ���� ���� ���๮�� ����˴ϴ�
���ǽ��� �����̸� ���๮�� �������� �ʽ��ϴ�
 
//���� ���ǽ��� ���̸� {} �ȿ� �ִ� ���๮�� �����϶�
 if(���ǽ�)
 {
    //���๮1
    //���๮2
    //....
}
 
 */
using UnityEngine;

//�ȳ��ϼ��並 3�� ����ϴ� ���α׷�
public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //dowhile
        //[1] �ʱ��
        int i = 4;

        do
        {
            //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");

            //[2]������
            i++;

        } while (i < 3);    //[3]���ǽ�

        //i:0 =>���=> i:1 => i<3 (��) => ��� => i:2 => i<3
    }
}

/*
 dowhile�� - �ݺ���

do
{
    //�ݺ� ���๮
}
 
 
 
 
 */
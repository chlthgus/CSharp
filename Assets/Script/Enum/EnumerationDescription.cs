using UnityEngine;

//�켱 ������ �����ϴ� ������ ����

enum Priority
{
    High,
    Normal,
    Low,
}
public class EnumerationDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]������ ���� ���� �� �ʱ�ȭ
        //������ ������ ����Ǵ� ���� ���ǿ��� ������� ��� ���������ϴ�
       /* Priority high = Priority.High;
        Priority normal = Priority.Normal;
        Priority low = Priority.Low;*/
    }
}

/*
 
 Enumerat(������) : �ϳ��� �̸����� ���� �����ִ� ���� ���� ������� ����
 
//����
enum (enum �̸�)
{
�����,
�����,
�����,
�����,
}
 
 */
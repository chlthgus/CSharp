using JetBrains.Annotations;
using UnityEngine;

//struct(����ü) : �ϳ��� �̸����� ���� �ٸ� ������ �����͵�, �Ǵ� �Լ����� ��� �����ϴ� �׸�
//[1] ����ü ����, ���� : �ΰ��� ������ �����ϴ� ����ü �����

struct Point
{
    public int x;   //publicŰ���带 �����Ͽ� �ܺο��� int x ������ ��� �����ϵ��� ����
    public int y;
}

public class StructDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ����ü ������ ���� ����:
        Point p;

        //[3] Point ����ü�� x,y ������ ���� ����(����, �Ҵ�) �ʱ�ȭ
        p.x = 100;
        p.y = 200;

        //[4]���
        Debug.Log($"x: {p.x}, y: {p.y}");
    }
}

/*
 
Variable(����) : �����͸� �����ϴ� �׸�
Array(�迭) : �ϳ��� �̸����� ���� ������ �����͸� ������ ��� �׸�, ����,I������ Ȯ��

 struct(����ü) : �ϳ��� �̸����� ���� �ٸ� �����͵�, �Ǵ� �Լ����� ��� �����ϴ� �׸� (������ ����),
: ����� ���� ������ ����

//����ü ����
struct (����ü �̸�)
{
    //���� �ٸ� ������ �����͵�
    //�Լ���
    
}
 
 */
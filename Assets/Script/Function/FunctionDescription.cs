using UnityEngine;

public class FunctionDescription : MonoBehaviour
{
    //[1] show �޼���(�Լ�) ����,  ����
    void show()
    {
        Debug.Log("Hello World!!!");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] show �Լ� ȣ��
        show();
    }
}

/*
 
Function(�Լ�) / Method(�޼���)
: �ݺ��ؼ� ����ϵ��� ������� �ϳ� �̻��� ��ɹ����� ������ �ڵ���
 
-���� �Լ� : ���(C#)���� �����ϴ� �Լ�, ����Ƽ���� �����ϴ� �Լ�
- ����� �Լ�:
 
-�Ű������� ���� �Լ�
-�Ű������� �ִ� �Լ�
-��ȯ���� �ִ� �Լ�

void �Լ��̸�(�Ű�����)
{
    //�ϳ� �̻��� ��ɹ�
    //....
}

(������ Ÿ��) �Լ��̸�(�Ű�����)
{
    //�ϳ� �̻��� ��ɹ�
    //....

    return ����(��) ;
}

//�Լ� ����
�Է� -> ó��(����) -> ���

//�Լ�(�޼���)
[1] �Լ� ���� (��� ����)
[2] �Լ� ȣ�� (��� ���)

 */

using UnityEngine;

//DefaultParameter(�⺻ �Ű�����, ������ �Ű�����)
public class DefaultParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�Ű� ������ �ִ� �Լ�
        PrintMessage();


        //�Ű� ������ �ִ� �Լ� ȣ��
        string error = "�����";
        PrintError(error);

        //��ȯ���� �ִ� �Լ� ȣ��
        //string errorLog = "error"();
    }

    //Message�� ����ϴ� �Լ�
    void PrintMessage()
    {
        string message = "�����";
        Debug.Log(message);
    }

    void PrintError(string message)
    {
        Debug.Log($"{message}");
    }

    void errorLog (string printerror)
    {
        Debug.Log($"����");
    }

}

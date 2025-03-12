using UnityEngine;

public class StringDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayName = "";
        var firstName = "�浿";
        var LastName = "ȫ";
        //[output] "�̸� : ȫ�浿"


        //[1]string ���ϱ�(+) ������ ���
        displayName = "�̸�: " + LastName + firstName;
        Debug.Log(displayName);

        //[2]string.format() �޼��� ���
        displayName = string.Format("�̸�: {0}{1},LastName, FirstName");
        Debug.Log(displayName);

        //[3]���ڿ� ������ ���
        displayName = $"�̸�: {LastName}{firstName}";
        Debug.Log(displayName);
    }
}

using UnityEngine;

public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //string ���� str �����ϰ� ������ �ʱ�ȭ
        string str = "";
        str = System.String.Empty;  // ������ ����
        str = " Abc Def Fed Cba ";  //�յڿ� ���� �ϳ����־ �� ����

        Debug.Log(str);
        Debug.Log(str.Length);  //���ڿ� ���� ���ϱ�
        Debug.Log(str[5]); //'D'���� ���
        Debug.Log(str.ToUpper());   // �빮��
        Debug.Log(str.ToLower());   // �ҹ���

        //���� ����
        Debug.Log(str.Trim());  //�յ� ���� ���� ����
        Debug.Log(str.TrimStart());//���ڿ� �պκ� ���� ����
        Debug.Log(str.TrimEnd());   //���ڿ� �޺κ� ���� ����

        //�˻�
        Debug.Log(str.IndexOf('e'));     //'e'�� ��ġ�� �ε��� ��������
        Debug.Log(str.Substring(5,3));  //5�� �ε������� 3���� ��������
        Debug.Log(str.Substring(5));  //5�� �ε������� ������ ��������
        Debug.Log(str.Remove(5,3));    //5�� �ε������� 3���� ���� ��������

        //��
        Debug.Log(str[1] == str[15]);   //false
        Debug.Log("ABC".Equals("Abc"));     //false
        Debug.Log(System.String.Compare("BAC","Bac"));  //0(����), 1, -1

        //����
        var hi1 = "�ȳ�";
        var hi2 = "�ϼ���";

        Debug.Log(hi1 + hi2);
        Debug.Log($"{hi1}{hi2}");
        Debug.Log(System.String.Format("{0}{1}", hi1 , hi2));

        //format
        Debug.Log(System.String.Format("{0:C}",1000));  //C : ��ȭ��
        Debug.Log(System.String.Format("{0}", 1000000));

        //�и��ϱ�
        string[] strArray = str.Trim().Split(' ');
        foreach(var s in strArray)
        {
            Debug.Log(s);
        }

       // Debug.Log(strAll);

    }
}

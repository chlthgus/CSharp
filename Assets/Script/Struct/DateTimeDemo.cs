using UnityEngine;

//
public class DateTimeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���� �ð� ���
        Debug.Log($"����ð�: {System.DateTime.Now}");

        //[2]���� ����Ͻú��� ���
        Debug.Log($"����ð�: {System.DateTime.Now.Year}");
        Debug.Log($"����ð�: {System.DateTime.Now.Month}");
        Debug.Log($"����ð�: {System.DateTime.Now.Day}");
        Debug.Log($"����ð�: {System.DateTime.Now.Hour}");
        Debug.Log($"����ð�: {System.DateTime.Now.Minute}");
        Debug.Log($"����ð�: {System.DateTime.Now.Second}");

        //[3] DateTime ����ü�� ������ �����ؼ� ���
        System.DateTime now = System.DateTime.Now;
        Debug.Log(now.Date);
        Debug.Log(now.ToLongTimeString());

    }
}

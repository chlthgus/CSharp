using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello Unity!!!");
        Debug.Log("123456789");

        Debug.Log("Hello Unity!!!\\n123456789");
    }

    /*
     [output] : �ܼ�â�� �Ʒ�  ������ ����ϼ���
     Hello Unity!!!
     123456789
     */

    // Update is called once per frame
    void Update()
    {
        
    }
}

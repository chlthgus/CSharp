using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�ϳ��� ������ �Է� �޾Ƽ� 
        //
        int number = 4;

        //¦�� �Ǻ���
        if (number%2==0)
        {
            Debug.Log($"{number}�� ¦��");
        }

        //Ȧ�� �Ǻ���
        if (number % 2 != 0)
        {
            Debug.Log($"{number}�� Ȧ��");
        }
        else
        {
                Debug.Log($"{number}�� ¦��");
            
        }    

        //3�� ���, 5�ǹ��, 7�ǹ�� �Ǻ���
        if(number %3 ==0)
        {
            Debug.Log($"{number}�� 3�� ���");
        }
        else if(number %5 == 0)
        {
            Debug.Log($"{number}�� 5�� ���");
        }
        else if (number % 7 == 0)
        {
            Debug.Log($"{number}�� 7�� ���");
        }

    }
}

using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result;

        result = Add(5, 3);
        Debug.Log(result);

        result = Substract(5, 3);
        Debug.Log(result);

        result = Multiply(5, 3);
        Debug.Log(result);

        result = Devide(5, 3);
        Debug.Log(result);

        result = Remainder(5, 3);
        Debug.Log(result);


    }

    //�ΰ��� ������ �Է¹޾� +,-,*,/,% ����Ͽ� ������� ��ȯ�ϴ� �Լ� �����
    int Add(int x, int y)
    {
        return x + y;
    }

    int Substract(int x, int y) => x - y;
    int Multiply(int x, int y) => x * y;
   int Devide (int x, int y) => x / y;

    int Remainder(int x, int y) => x % y;


}


/*
[Q] 
��Ģ������ ���ϴ� �Լ� �����
+,-,*,/,% ����Ͽ�
������� ��ȯ�ϴ� �Լ� �����
add,subtract,multiply,davide,remainder

�Է°� : 5,3

[output]



 
 
 */
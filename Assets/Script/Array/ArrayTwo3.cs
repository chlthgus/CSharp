using UnityEngine;

public class ArrayTwo3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 2���� �迭 ����: ù��° ��Ҽ�(ũ��)�� ����
        int[][] intArray = new int[2][];

        //[2] 2���� �迭 ��Ҽ�(ũ��) ���� ���� �����Ѵ�, �ʱ�ȭ
        intArray[0] = new int[3] { 1, 2, 3 };
        intArray[1] = new int[2] { 4, 5 } ;


        //[3] �迭�� ����
        Debug.Log($"�迭�� ����:{intArray.Length}");     //2


        //[4] 2���� �迭 ����ϱ�
        for (int i = 0; i<2; i++)
        {
            for (int j = 0; j<3; j++)
            {
                Debug.Log(intArray[i][j]);
            }
            Debug.Log("===========");
        }

    }
}

using UnityEngine;

//1���� 10������ ������ ���� ���ϴ� ���α׷�����
//���� ���� 22�̻��� �Ǹ� ���̻� ���� ������ �ʴ´�
//while�� �̿�
public class WhileBreak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;
        int goal = 22;

        int i = 1;

        while(i<= n)
        {
            //�ݺ� ���๮
            sum = sum + i;

            //���� �� (sum)�� 22(goal)�̻��� �Ǹ�
            if(sum >= goal)
            {
                break;
            }

            //������
            i++;
        }
        Debug.Log(sum);


    }
}

using UnityEngine;

//��ø ����ü: ����ü �ȿ� ����ü
//������ �����ϴ� ����ü �����
//������ ������ �����ϴ� ����ü ����
struct Score
{
    public int kor; //��������
    public int eng; //��������
}

//�л� ������ �����ϴ� ����ü ����- ���� ����
struct Student
{
    public int number; //�л���ȣ
    public string name; //�л��̸�
    public Score scores; //�������� - Score ����ü : ��ø ����
}
public class StructPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����ü ���� ���� �� ��Ҽ� ����
        Student[] students = new Student[3];

        //[2] �л� ����ü �ʱ�ȭ
        students[0].number = 1;
        students[0].name = "ȫ�浿";
        students[0].scores.kor = 100;
        students[0].scores.eng = 90;

        students[0].number = 2;
        students[0].name = "��λ�";
        students[0].scores.kor = 90;
        students[0].scores.eng = 80;

        students[0].number = 3;
        students[0].name = "�Ӳ���";
        students[0].scores.kor = 90;
        students[0].scores.eng = 75;

        //[3] �л� ����ü ��� - ����ǥ ���
        for(int i =0; i<students.Length; i++)
        {
            Debug.Log($"{students[i].number} - {students[i].name} : ����{students[i].scores.kor}��, ����{students[i].scores.eng}��");
        }

    }
}

using UnityEngine;

public class IfEclePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        int score = 85;
        //string medal = "";

        //[1] score�� 90�̻��̸�
        if (score >= 90)
        {
            //medal = "�ݸ޴�";
        }
        else   // 0~89
        {
            //[2] 80�̻��̸� ���޴�
            if (score >= 80) 
            {
                //medal = "���޴�";
            }
            else
            {
                //[3] 70�̻��̸� ���޴�
                if(score >=70)
                {
                    //medal = "���޴�";
                }
                else //0~69
                {
                    //medal = "��޴�";
                }
            }
        }



        /*  if(g > score)
          {
              Debug.Log("�ݸ޴��� �����Ͽ����ϴ�");
          }

          if (s > score)
          {
              Debug.Log("���޴��� �����Ͽ����ϴ�");
          }

          if (u > score)
          {
              Debug.Log("���޴��� �����Ͽ����ϴ�");
          }

          if (f > score)
          {
              Debug.Log(" ");
          }*/

    }
}
      
/*
 
[Q]
score�� 90�̻��̸� �ݸ޴� ���, 80�̻��̸� ���޴� ���
70�̻��̸� ���޴� ���, �׿� �������� ��޴� ���
score�� 85��

[output]
()�޴��� �����Ͽ����ϴ�
 
 
 */
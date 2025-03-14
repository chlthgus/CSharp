using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class AveragePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] data = { 90, 65, 78, 50, 95 };

        double average = 0;
        int sum = 0;
        int count = 0;

        for (int i = 0; i < data.Length; i++) 
        {
            if (data[i] >= 80 && data[i]<=95) 
            {
                sum = sum + data[i];
                count++;
            }
        }

        if(count>0)
        {
            average = sum / (double)count;
        }
        Debug.Log($"평균점수:{average}");
    }
}

/*

[Q]
입력데이터 (90,65,78,50,95)
국어점수중 70점 이상이고 95점 이하인 점수들의 평균을 구하라

[output]
평균점수:average
 


 */

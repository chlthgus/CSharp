using UnityEngine;

public class IfEclePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        int score = 85;
        int g = 90;
        int s = 80;
        int u = 70;
        int f = 0;



        
        if(g > score)
        {
            Debug.Log("금메달을 수상하였습니다");
        }

        if (s > score)
        {
            Debug.Log("은메달을 수상하였습니다");
        }

        if (u > score)
        {
            Debug.Log("동메달을 수상하였습니다");
        }

        if (f > score)
        {
            Debug.Log(" ");
        }

    }
}

/*
 
[Q]
score가 90이상이면 금메달 출력, 80이상이면 은메달 출력
70이상이면 동메달 출력, 그외 나머지는 노메달 출력
score는 85점

[output]
()메달을 수상하였습니다
 
 
 */
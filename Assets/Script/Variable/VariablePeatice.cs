using Unity.VisualScripting;
using UnityEngine;

public class VariablePeatice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 변수 선언
        int first, second, third;

        //[2] 변수에 값 저장
        first = 10;
        second = 20;
        third = 30;

        //[3] 변수 사용
        Debug.Log(first + "," + second + "," + third);

        
        //int First = 10;
       // Debug.Log("First : " + First);

    }
}

/*
[Q]
변수: first, second, thied 정의하고 값 대입하여 아래내용 출력

[out put]
10,20,30
*/

using UnityEngine;

public class WhileSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;    //결과를 저장하는 변수

        //[1] 초기식
        int i = 1;

        while (i <= n) //[2]조건식
        {
            //반복 실행문
            sum += i;

            //[3]증감식
            i++;

        }

        Debug.Log($"1부터 {n}까지의 짝수의 합: {sum}");
    }
}

using UnityEngine;

//1부터 10까지의 정수 중 짝수의 합을 구하는 프로그램 구현
public class ForSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 2 + 4 + 6 + 8 + 10

        int n = 10;
        int sum = 0;

        for(int i = 1; i < n+1; i++ )
        {
            //반복 실행문 -짝수만 더한다
            if(i%2 ==0) //짝수 판별식을 통해 짝수만 더한다
            {
                sum = sum + i;
            }
        }

        Debug.Log($"1부터 {n}까지의 합은 {sum}");
    }
}

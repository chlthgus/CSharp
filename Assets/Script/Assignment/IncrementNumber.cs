using UnityEngine;

//정수형 변수의 값을 1씩 증가
public class IncrementNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 변수num을 선언하고 10으로 초기화
        int num = 10;       // num :10

        num = num + 1;      // num 1 증가식 ( num에 1을 더하고 그 값을 num에 저장하기)

        Debug.Log(num);


    }
}
using UnityEngine;

//DecrementOperator(감소 연산자) : 정수형 변수의 값을 1감소
public class DecrementOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = -100;

        //1 감소식
        //num = num-1;
        //num -= 1;
        --num;          //-101

        Debug.Log("num: " + num);

    }
}
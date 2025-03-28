using UnityEngine;

//Index(인덱스)
public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //크기가 3인 정수형 배열 선언하고 초기화
        int[] numbers = { 1, 2, 3 };
        //number[0] -> 1, number[1] -> 2, number[2] -> 3

        int index = 0;

        Debug.Log(numbers[index++]);    // => number[0] => 1, index: 1
        Debug.Log(numbers[index++]);    // => number[1] => 2, index: 2
        Debug.Log(numbers[index++]);    // => number[2] => 3, index: 3

        Debug.Log(numbers[--index]);    // => index: 2 ,  number[2] => 3
        Debug.Log(numbers[--index]);    // => index: 1 ,  number[1] => 2
        Debug.Log(numbers[--index]);    // => index: 0 ,  number[0] => 1

    }
}

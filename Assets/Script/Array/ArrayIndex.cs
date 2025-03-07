using UnityEngine;

//Index(�ε���)
public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ũ�Ⱑ 3�� ������ �迭 �����ϰ� �ʱ�ȭ
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

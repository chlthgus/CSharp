
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenericDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]제네릭 사용전
        Stack st1 = new Stack();
        st1.Push(1234);
        int number1 = (int) st1.Pop();
        Debug.Log(number1);

        //[2]제네릭 사용시
        Stack<int> st2 = new Stack<int>();
        st2.Push(5678);
        int number2 = st2.Pop();
        Debug.Log(number2);

        //[3]제네릭 장점:형식의 안정성, 성능향상
        //형식의 안정성
        Stack o = new Stack();
        o.Push(1234);
        o.Push("Hello");
        Debug.Log(o.Pop());
        Debug.Log(o.Pop());

        Stack<int> i = new Stack<int>();
        i.Push(2345);
        //i.Push("TEN"); // int만 처리 가능
        Debug.Log(i.Pop());

        //성능, 최적화
        Stack stack = new Stack();
        stack.Push(1234);
        int iStack = (int)stack.Pop();
        Debug.Log(iStack);
    }
}

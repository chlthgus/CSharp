using UnityEngine;

//안녕하세요를 3번 출력하는 프로그램
public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //dowhile
        //[1] 초기식
        int i = 4;

        do
        {
            //반복 실행문
            Debug.Log("안녕하세요");

            //[2]증감식
            i++;

        } while (i < 3);    //[3]조건식

        //i:0 =>출력=> i:1 => i<3 (참) => 출력 => i:2 => i<3
    }
}

/*
 dowhile문 - 반복문

do
{
    //반복 실행문
}
 
 
 
 
 */
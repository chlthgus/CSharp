using UnityEngine;

//로또 번호 생성기
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Random
        System.Random rand = new System.Random();

        int[] numbers = new int[6];



        for (int i = 0; i <6; i++)
        {
            numbers[i] = rand.Next(1, 46);
        }


    }
}

/*
 
 [Q]
로또 번호 생성기 만들기
[1] 6개 번호
[2] 1~45번 사이의 랜덤 번호
[3] 중복된 숫자가 나오면 안된다


[1], [2] 먼저 구현

[output] - 조건에 맞는 번호 6개 출력
 
 
 */
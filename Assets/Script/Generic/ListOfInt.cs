using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ListOfInt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 배열 - 정수형 배열 변수 선언하고 요소수 생성
        int[] arrNumber = new int[2];

        //[2]배열 초기화
        arrNumber[0] = 10;
        arrNumber[1] = 20;

        //[3] 배열 사용
        for (int i = 0; i< arrNumber.Length; i++)
        {
            Debug.Log(arrNumber[i]);
        }

        //제네릭 리스트 : List<T>
        //int형 전용의 List 인스턴스 생성
        List<int> IstNumbers = new List<int>();

        //[2]리스트에 데이터 넣기
        IstNumbers.Add(30);
        IstNumbers.Add(40);

        //[3]리스트 사용
        for (int i = 0; i<IstNumbers.Count; i++)
        {
            Debug.Log(IstNumbers[i]);
        }

        IstNumbers.Add(50);
        for (int i = 0; i<IstNumbers.Count; i++)
        {
            Debug.Log(IstNumbers[i]);
        }



    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DictionaryDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Dictionary클래스의 인스턴스 생성 : IDictionary 인터페이스 받기
        IDictionary<string, string> data = new Dictionary<string, string>();

        //[2]Dictionary 데이터 넣기
        data.Add("시", "서울특별시");
        data.Add("구", "강동구");

        //[3]Dictionary 데이터 삭제
        data.Remove("시");

        //[4]Dictionary데이터 넣기 = 인덱서를 사용해서 넣기
        data["동"] = "천호동";

        //[5]
        data["구"] = "강남구";

    }
}

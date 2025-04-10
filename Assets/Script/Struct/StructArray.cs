using UnityEngine;

//[1]구조체 정의, 선언 : 고객의 데이터를 관리하는 구조체
struct UserInfo
{
    public string name;     //고객이름
    public int age;     //고객나이
    //....
}
public class StructArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 구조체 변수 선언
        UserInfo info;
        //[2] 구조체 초기화
        info.name = "홍길동";
        info.age = 20;
        //[3]
        PrintUserInfo(info.name, info.age);

        //[1] 구조체의 배열 변수 선언, 배열의 요소수 (크기)생성
        UserInfo[] userinfos = new UserInfo[2];
        //[2] 구조체 배열 초기화
        userinfos[0].name = "백두산";
        userinfos[0].age = 22;
        userinfos[1].name = "임꺽정";
        userinfos[1].age = 33;

        //[3] 구조체 배열 사용
        for (int i = 0; i < userinfos.Length; i++)
        {
            PrintUserInfo(userinfos[i].name, userinfos[i].age);
        }

    }
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name}님의 나이는 {age}살 입니다");
    }

    void PrintUserInfo()
    {

    }
}

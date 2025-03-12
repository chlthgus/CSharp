using UnityEngine;

public class StringDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 관련 메서드 - 대문자 소문자 바꾸기
        string message = "Hello World!";
        Debug.Log(message);

        //[1]대문자
        Debug.Log(message.ToUpper());

        //[2]소문자
        Debug.Log(message.ToLower());

        //[3]바꾸기
        Debug.Log(message.Replace("Hello", "안녕하세요").Replace("World!", "세계!"));
    }
}

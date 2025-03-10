using UnityEngine;

//DefaultParameter(기본 매개변수, 선택적 매개변수)
public class DefaultParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //매개 변수가 있는 함수
        PrintMessage();


        //매개 변수가 있는 함수 호출
        string error = "디버그";
        PrintError(error);

        //변환값이 있는 함수 호출
        //string errorLog = "error"();
    }

    //Message를 출력하는 함수
    void PrintMessage()
    {
        string message = "디버그";
        Debug.Log(message);
    }

    void PrintError(string message)
    {
        Debug.Log($"{message}");
    }

    void errorLog (string printerror)
    {
        Debug.Log($"에러");
    }

}

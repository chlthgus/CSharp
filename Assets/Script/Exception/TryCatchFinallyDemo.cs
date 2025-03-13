using UnityEngine;

public class TryCatchFinallyDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 5;
        int y = 5;
        int r = 0;

        try     //예외가 발생할 가능성이 있는 구문
        {
            //[1]
            r = x / y;
            Debug.Log($"{x} / {y} = {r}");
        }
        catch   //try 절 에서 예외가 발생하면 catch 절 실행
        {
            //[2]
            Debug.Log("예외가 발생했습니다");
        }
        finally     //try절에서 예외가 발생하던, 안하던 상관없이 실행
        {
            //[3]
            Debug.Log("프로그램을 종료합니다");
        }
    }
}

using UnityEngine;

public class StringCompair : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "Hello";
        string s2 = "Hello";

        //만약 s1과 s2가 같으면 same이라고 출력
        if(s1 ==s2)
        {
            Debug.Log("same");
        }

        //
        bool bln = false;

            //만약 bin값이 false 이면 실행문을 실행
            if(bln == false)
        {
            Debug.Log("bln: " + bln);
        }

        // !bln 값이 참이면 실행문을 실행
        if(!bln)
        {
            Debug.Log("!bln" + !bln);
        }


    }
}

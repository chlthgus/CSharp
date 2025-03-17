using UnityEngine;

//classone,two를 사용하기
public class ClassDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //다른 클래스 멤버 호출
        ClassOne.Hi();
        ClassTwo.Hi();

        ClassTwo two = new ClassTwo();
        two.Hello();
    }
}

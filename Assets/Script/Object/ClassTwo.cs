using UnityEngine;

public class ClassTwo : MonoBehaviour
{
    //정적(스타틱)멤버 메서드
    public static void Hi()
    {
        Debug.Log("반갑습니다");
    }

    //인스턴스 멤버 메서드 - 스타틱()없는 메서드
    public void Hello()
    {
        Debug.Log("또 만나요");
    }

}

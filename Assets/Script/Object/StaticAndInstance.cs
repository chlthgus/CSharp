using UnityEngine;

//정적(static) 멤버와 인스턴스 멤더
//[1]클래스선언
public class ShareAndInstance
{
    //static 멤버 메서드
    public static void StaticMember() => Debug.Log("[1] Static Mamber");

    //instance 멤버 메서드
    public void InstanceMember() => Debug.Log("[2] Instance Member");




}

public class StaticAndInstance : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ShareAndInstance클래스 사용
        //[1]정적 멤버사용 => 클래스이름.멤버이름 으로호출
        ShareAndInstance.StaticMember();

        //[2] 인스턴스 멤버 사용 => 개체이름.멤버이름으로 호출
        ShareAndInstance obj = new ShareAndInstance();
        obj.InstanceMember();
    }
}

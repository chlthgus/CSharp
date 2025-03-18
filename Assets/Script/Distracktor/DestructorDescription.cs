using UnityEngine;

namespace Constructor
{
    public class DestructorDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //DestructorTest클래스의 인스턴스 생성
            DestructorTest destructorTest = new DestructorTest();

            //인스턴스사용
            destructorTest.Run();

            //GC.Collect - DestructorTest클래스의 소멸자 호출
            //~DestructorTest();

        }
    }
}
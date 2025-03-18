using UnityEngine;
namespace PrivatePublic
{

    public class PublicPrivate
    {
        //static 정적 필드 선언
        public static string name = "트럭";

        //필드
        private int age;

        //static 정적 메서드
        //이름을 반환하는 함수
        public string GetName()
        {
            return name;
        }

        public void SetAge(int nai)
        {
            age = nai;
        }

        public int GetAge()
        {
            return age;
        }

    }
}
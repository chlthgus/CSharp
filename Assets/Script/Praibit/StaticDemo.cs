using UnityEngine;
namespace PrivatePublic
{

    public class StaticDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //PublicPrivate 클래스의 정적필드,정적 메서드 사용
            //클래스이름.정적필드이름,클래스이름,정적메서드 이름
            PublicPrivate.name = "홍길동";
            Debug.Log(PublicPrivate.name);

            /*


            string sName = PublicPrivate.GetName();
            Debug.Log(sName);

            PublicPrivate publicPrivate = new PublicPrivate();
            publicPrivate.SetAge = (22);
            int myAge = publicPrivate.GetAge
                        
            */
        }
    }
}
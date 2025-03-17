using UnityEngine;
namespace PrivatePublic
{
    public class PublicAndPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Car myCar = new Car();

            myCar.name = "홍길동";

            Debug.Log(myCar.name);

        }
    }
}
using UnityEngine;
namespace Constructor
{
    public class ConstructorNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Person saram1 = new Person();
            Debug.Log(saram1.GetName());

            Person saram2 = new Person();
        }
    }
}
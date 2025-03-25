using UnityEngine;

namespace Override
{
    public class MethodOverride : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Base parent = new Base();
            parent.Work();

            Sub child = new Sub();
            child.Work();


        }
    }
}

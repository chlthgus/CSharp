using UnityEngine;

namespace PrivatePublic
{


public class VariableScope : MonoBehaviour
{
    string globalVariable = "전역 변수";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            string localVariable = "지역변수";
            Debug.Log(localVariable);

            Debug.Log(globalVariable);

            TestPrint();
    }

        void TestPrint()
        {
            //Debug.Log(local
        }
}
}
using UnityEngine;

namespace Method
{
    public class ParameterIn : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

            int num = 10;
            Debug.Log($"[1]:{num}");

            PrintNumber(num);

            Debug.Log($"[3]:{num}");
        }

        void PrintNumber(int num)
        {
            num = 20;
            Debug.Log($"[2]:{num}");
        }
    }
}
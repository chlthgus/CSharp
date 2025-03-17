using UnityEngine;

namespace PrivatePublic
{
    public class LocalVariable : MonoBehaviour
    {

        void Start()
        {
            int i = 1234;
            int j = 4567;

            Debug.Log(i+j);

        }
    }
}

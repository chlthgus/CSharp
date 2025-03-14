using UnityEngine;

public class NullNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string nullValue = null;
        string message = "";

        if(nullValue == null)
        {
            message = "null이면새로운 값으로 초기화";
        }

        Debug.Log(message);

        int? len;
        string msg = null;

        if (msg != null)
        {
            len = msg.Length;

        }
        else
        {
            len = null;
        }


    }
}

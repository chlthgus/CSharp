using UnityEngine;

public class StringEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string userName = "RedPlus";
        string inputName = "redplus";

        //[1]연산자 (==)
        if(userName.ToLower() == inputName.ToLower())
        {
            Debug.Log("[1]같습니다");
        }

        //[2] string.Equal()메서드 사용
       // string 
    }
}

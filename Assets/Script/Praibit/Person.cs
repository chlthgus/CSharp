using UnityEngine;

namespace PrivatePublic
{


    public class Person
    {

        private string name = "홍길동";

        private const int AGE = 21;

        private readonly string NickName = "도깨비";

        private string[] address = { "서울", "수원", "인천" };

        private object obj = System.DateTime.Now.ToShortTimeString();

        private void ShowProfile()
        {
            Debug.Log($"이름:{name},나이{AGE},별명:{NickName}");
        }

    }
}
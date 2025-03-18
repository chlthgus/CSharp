using UnityEngine;

namespace PrivatePublic 
{
public class Car
{
    public string name;
    private int age;
        string address;

        public void Hi()
        {
            Debug.Log("안녕하세요");
        }

        public void Bye()
        {
            Debug.Log("안녕히계세요");
        }

        public void Setage(int iAge)
        {
            age = iAge;
        }
}

}
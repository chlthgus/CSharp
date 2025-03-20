using UnityEngine;

public class DelegateDescription : MonoBehaviour
{

    delegate void SayDelegate();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hi();

        SayDelegate say = Hi;

        say();

        SayDelegate hello = new SayDelegate(Hi);

        hello();




    }

   void Hi()
    {
        Debug.Log("안녕하세요");
    }
}

using UnityEngine;


public class My
{

}

public class Your
{
    public override string ToString()
    {
        return "새롭게 지정된 이름";
    }
}


public class ToStringMethod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        My my = new My();

        Debug.Log(my);


        Your your = new Your();
        Debug.Log(your);
    }
}

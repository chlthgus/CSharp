using UnityEngine;

public class ShortcutOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        x = x + 2;   //x를 2증가식
        Debug.Log("x: " + x);

        int y = 3;
        //y =y +2;
        y += 2;     //축약형
        Debug.Log("y: " + y);
    }
}
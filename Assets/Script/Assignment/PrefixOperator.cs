using UnityEngine;

//PrefixOperator(전위 증강 연산자) : 같은 라인에서 연산하는 우선순위가 가장 높음(가장 먼저 연산)
public class PrefixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = ++i;

        Debug.Log("j: " + j);       // = 4
    }
}
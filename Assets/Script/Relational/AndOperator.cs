using UnityEngine;

//LogicalOperator (논리 연산자) - &&, || , !
//AndOperator (And 연산자) : && 둘 다 참일 때만 참
//결과 : true, false
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 둘 다 참일때만 참
        Debug.Log(true && true);    //=> true

        //[2] 둘 중에 하나라도 거짓이라면 거짓
        Debug.Log(true && false);   //=> false
        Debug.Log(false && true);   //=> false

        //[3] 둘 다 거짓이면 거짓
        Debug.Log(false && false);      //=> false

    }
}
using UnityEngine;

// 1, 2, 3, 4, 5
// 5, 4, 3, 2, 1
public class ForCountDownDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1���� 5���� 1�� ����
        for (int i = 1; i < 5+1; i++)
        {
            Debug.Log($"���� Countdown: {i}");
        }
        Debug.Log("=============================");



        //[2] 5���� 1���� 1�� ����
       /* for (int i=5; i > 1-1; i--)
        {
            Debug.Log($"���� Countdown: {i} ");
        }    */
       // 5, 4, 3, 2, 1

        // 0, 1, 2, 3, 4
        for (int i = 0; i <5; i++) // 5�� �ݺ�
        {
            Debug.Log($"���� Countdown: {(5 - i)}");
        }
    }
}

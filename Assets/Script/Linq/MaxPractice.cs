using UnityEngine;

public class MaxPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] data = { -2, -5, -3, -7, -1 };

        int max = int.MaxValue;
        
        for(int i=0;i<data.Length;i++)
        {
            if (data[i] > max)
            {
                max = data[i];
            }
        }
    }
}


/*

[Q]
입력데이터 (-2,-5,-3,-7,-1)
입력 데이터중에서 최댓값을 구하세요
[output]
최댓값 : -1
 


 */

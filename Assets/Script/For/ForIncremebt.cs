using UnityEngine;

// ForIncrement 
public class ForIncremebt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������
        // 0���� 10���� 2�� �����ϸ鼭 ���
        //0,2,4,6,8,10
        for (int i =0; i<11; i = i+2)
        {
            Debug.Log(i);
        }
    }
}

using UnityEngine;

//[1]�������� �����ϴ� ������ ����
// ������ ������� ���� 0���� �����ؼ� 1�� ����

enum Animale
{
    Horse,
    Sheep,
    Monkey,
}
public class EnumIndexChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((int)Animale.Monkey);     // 2
    }
}

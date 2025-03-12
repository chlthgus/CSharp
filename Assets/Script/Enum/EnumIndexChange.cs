using UnityEngine;

//[1]동물들을 구분하는 열거형 생성
// 열거형 순서대로 값은 0부터 시작해서 1씩 증가

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

using UnityEngine;
enum Animals
{
    Deagon,
    Cow,
    Tiger,
}

public class EnumIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animals animal = Animals.Deagon;
            int num = (int)animal;
        string str = animal.ToString();

        Debug.Log($"Animals.Dragon: {num},{str}");
    }
}

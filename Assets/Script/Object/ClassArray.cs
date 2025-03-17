using UnityEngine;

public class CategoryClass
{
    public void Print(int i) => Debug.Log($"카테고리{i}");
}

public class ClassArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CategoryClass[] categories = new CategoryClass[3];

        categories[0] = new CategoryClass();
        categories[1] = new CategoryClass();
        categories[2] = new CategoryClass();

        for(int i= 0; i<categories.Length;i++)
        {
            categories[i].Print(i);
        }

    }
}

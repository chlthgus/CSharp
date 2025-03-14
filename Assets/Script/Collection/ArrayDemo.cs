using UnityEngine;

public class ArrayDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] colors = { "red", "green", "blue" };

        Debug.Log($"배열의 요소수 갯수 {colors.Length}");
       for (int i = 0; i < colors.Length; i++)
        {
            Debug.Log(colors[i]);
        }
    }
}

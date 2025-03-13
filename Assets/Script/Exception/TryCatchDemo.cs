using UnityEngine;

public class TryCatchDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int now = System.DateTime.Now.Second;
            Debug.Log($"«ˆ¿Á√ : {now}");

            int result = 2 / (now % 2);
        }

        catch
        {

        }
    }
}

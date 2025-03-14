using System.Linq;
using UnityEngine;

public class LinkCount2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool[] blns = { true, false, true, false, true };

        Debug.Log(blns.Count());

        Debug.Log(blns.Count(b => true ));
        Debug.Log(blns.Count(a => a== false));
    }
}

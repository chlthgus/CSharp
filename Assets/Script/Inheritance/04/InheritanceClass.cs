using UnityEngine;
namespace Inheritance04
{
    public class InheritanceClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            ParentClass parent = new ParentClass();
            Debug.Log(parent.ToString());


        }
    }
}
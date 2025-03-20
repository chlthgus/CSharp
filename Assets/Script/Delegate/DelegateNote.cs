using UnityEngine;
namespace Delegate
{


    public class DelegateNote : MonoBehaviour
    {

        delegate void GoHome();

        GoHome go;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            /*
            CarDriver.GoForward();
            CarDriver.GoRight();
            CarDriver.GoLeft();
            **/

           // go = new GoHome(CarDriver.GoForward)

        }
    }
}
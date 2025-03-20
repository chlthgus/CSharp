using UnityEngine;
namespace Delegate
{
    public class CarDriver
    {
        public void GoForward()
        {
            Debug.Log("직진");
        }

        public void GoLeft()
        {
            Debug.Log("좌회전");
        }

        public void GoRight()
        {
            Debug.Log("우회전");
        }



    }
}
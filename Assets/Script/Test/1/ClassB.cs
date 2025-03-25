using System;
using System.Collections.Generic;
using UnityEngine;


namespace Class
{
    class B : MonoBehaviour
    {
        void Start()
        {
            
            A aInstance = new A();
            string[] daysArray = aInstance.GetDays();

            
            List<string> daysList = new List<string>(daysArray);
            int result = A.Add(5, 6);
            daysList.Add(result.ToString());


            foreach (string day in daysList)
            {
                Debug.Log(day);
            }
         
        }
    }

}
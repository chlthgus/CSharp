using System;
using System.Collections.Generic;
using UnityEngine;


namespace Class
{
    class A : MonoBehaviour
    {
       
        private string[] days = { "일", "월", "화", "수", "목", "금", "토" };

       
        public string[] GetDays()
        {
            return days;
        }

       
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
using System;
using UnityEngine;

public class ClassB
{
    class B
    {
        static void Main()
        {
            A aInstance = new A();
            aInstance.PrintDays();

            int result = A.Add(5, 6);
            Console.WriteLine(result);
        }
    }

}

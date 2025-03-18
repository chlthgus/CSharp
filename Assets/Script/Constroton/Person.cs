using UnityEngine;
namespace Constructor
{
    public class Person
    {
        private string name;

        public Person()
        {
            name = "홍길동";
        }

        public Person(string _name)
        {
            name = _name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
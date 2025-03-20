using UnityEngine;
namespace Indexer
{
    public class Person
    {

        public string name;

        public string this[int index]
        {
            get { return name; }
            set { name = value; }
        }
        /*
        
        private string name;

        private string Name
        {
            get (return name;)
            set (name = value;)
        }
        public void SetName(string _name)
        {
            name = _name;

        }

         */
    }
}
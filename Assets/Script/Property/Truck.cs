using UnityEngine;
namespace Property
{
    public class Truck
    {
        //이름,색상
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Color { get; set; }

        public int Number { get; set; } = 1234;
    }
}
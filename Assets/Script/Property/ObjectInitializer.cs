using UnityEngine;

namespace Property
{ 
public class ObjectInitializer : MonoBehaviour
    {
        /*
               void start()
               {

                   Student s1 = new Student();
                   s1.Name = "홍길동";
                   s1.age = 22;
                   Debug.Log($"이름:{s1.Name},나이:{s1.Age},번호:{s1.Number}");

                   Student s2 = new Student() { Name = "백두산", Age = 20, number = 2 };
                   Debug.Log($"이름:{s2.Name},나이:{s2.Age},번호:{s2.Number}");

                   Student s3 = new Student() { Name = "장길산", Age = 18, number = 3 };
                   Debug.Log($"이름:{s2.Name},나이:{s2.Age},번호:{s2.Number}");

               }
               private string name;
               private string address;

               public string Name
               {
                   get { return name; }
                   set { name = value;  }

               }
          */
        public int Age { get; set; }
        public int Number { get; set; } = 1;


 
     
}
}
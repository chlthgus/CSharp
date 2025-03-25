using UnityEngine;

namespace Override
{
    public class Base
    {
        public virtual void Work() => Debug.Log("부모가 일한다");


    }

    public class Sub : Base
    {
        public override void Work()
        {
            Debug.Log("자식이 일한다");
        }
    }
}
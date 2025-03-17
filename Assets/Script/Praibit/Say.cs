using UnityEngine;

namespace PrivatePublic
{ 
public class Say
{

        string message = "안녕하세요";

        public void Hi()
        {
            this.message = "반갑습니다";
            Debug.Log(this.message);
        }
}

}
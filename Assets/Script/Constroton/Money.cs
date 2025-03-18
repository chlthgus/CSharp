using UnityEngine;
namespace Constructor
{
    public class Money
    {
        public Money() : this(1000)
        {
            Debug.Log("기본 생성자 실행");

        }

        public Money(int gold)
        {
            Debug.Log($"Money: {gold:#,###}");
        }
    }
}
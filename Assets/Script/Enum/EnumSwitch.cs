using UnityEngine;

//열거형은 switch문과 함께 많이 사용된다

enum Animalw
{
    Chicken,
    Dog,
    Pig,
}
public class EnumSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //열거형 변수 선언, 초기화
        Animalw ani = Animalw.Dog;
        PrintAnimal(ani);
    }
    void PrintAnimal(Animalw animal)
    {
        //switch(animal)
        {
            //case Animalw.Chicken 
        }
    }
}

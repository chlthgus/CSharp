using UnityEngine;

//�������� switch���� �Բ� ���� ���ȴ�

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
        //������ ���� ����, �ʱ�ȭ
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

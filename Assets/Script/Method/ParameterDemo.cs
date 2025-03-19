using UnityEngine;

public class ParameterDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //몬스터 생성
        Monster monster1 = new Monster(100,10);
        Monster.monsterCount++;

        Monster monster2 = new Monster(200, 20);
        Monster.monsterCount++;


        MonsterBattle(monster2, monster1);

        Debug.Log($"monster1 HP:{monster1.hp}, atk:{monster1.atk}");
        Debug.Log($"monster2 HP:{monster2.hp}, atk:{monster2.atk}");
        Debug.Log($"monsterCount:{Monster.monsterCount}");


    }
     
    void MonsterBattle(Monster atkMonster,Monster defMonster)
    {
        defMonster.hp -= atkMonster.atk;
    }
}

public class Monster
{
    public static int monsterCount = 0;

    public int hp;
    public int atk;

    public Monster(int hp, int atk)
    {
        this.hp = hp;
        this.atk = atk;
    }
}
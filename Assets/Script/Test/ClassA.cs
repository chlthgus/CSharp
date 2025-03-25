using System;

class A
{
    private string[] days = { "일", "월", "화", "수", "목", "금", "토" };

    public void PrintDays()
    {
        foreach (string day in days)
        {
            Console.WriteLine(day);
        }
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }
}
using UnityEngine;

public class User
{
    private int birthYear;

    public string Name { get; set; }

    public int BirthYear
    {
        set
        {
            birthYear = value;
        }
    }

    public int Age
    {
        get
        {
            return(System.DateTime.Now.Year - birthYear);
        }
    }


}

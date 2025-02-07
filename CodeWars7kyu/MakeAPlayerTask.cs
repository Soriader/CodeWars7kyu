namespace CodeWars7kyu;

public class Player
{
    public string Name{get; set;}
    public string Position{get; set;}
    public int Age{get; set;}
    public int Dribbling{get; set;}
    public int Pass{get; set;}
    public int Shoot{get; set;}

    public Player(string name, string position, int age, int dribbling, int pass, int shoot)
    {
        Name = name;
        Position = position;
        Age = age;
        Dribbling = dribbling;
        Pass = pass;
        Shoot = shoot;
    }
}
//https://www.codewars.com/kata/5630c850ed4343c1d0000083/train/csharp
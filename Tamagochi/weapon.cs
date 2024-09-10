public class weapon
{


    public string Name;
    public int MinDamage;
    public int MaxDamage;


    public weapon(){
        Console.WriteLine("skapades!");
        MinDamage = 10;
        MaxDamage = 20;
        Name = "yxa";
    }


    public int Attack()
    {
        Console.WriteLine($"Attackerar med {Name}");
        return Random.Shared.Next(MinDamage, MaxDamage);
    }
    
}
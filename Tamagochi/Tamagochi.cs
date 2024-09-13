


public class tamagochi{
    private int Hunger;
    private int Boredom;
    private List<string> words = new List<string>() {"hello"};
    private bool isAlive;
    private Random generator;
    private string name;
}



  public Tamagotchi()
  {
    generator = new Random();
    isAlive = true;
  }



/*                                                  Publika klasser                                                                               */
/*---------------------------------------------------------------------------------------------------------------------------------*/



public void Feed()
{
    
}
public void Hi()
{

}
public void Teach(string words)
{
Console.WriteLine($"[{name}] lär sig att {word}")
words.Add(word);
ReduceBoredom();
}

public void Tick()
{

}
public void PrintStats()
{

}
public bool GetAlive()
{

}


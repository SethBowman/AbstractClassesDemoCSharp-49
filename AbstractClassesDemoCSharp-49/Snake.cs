namespace AbstractClassesDemoCSharp_49;

public class Snake : Animal
{
    public override void Move()
    {
        Console.WriteLine("Snake slithers!");
    }

    public override void Breathe()
    {
        Console.WriteLine("Snake breathes!");
    }
}
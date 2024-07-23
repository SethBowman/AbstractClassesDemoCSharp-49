namespace AbstractClassesDemoCSharp_49;

public class Dog : Animal
{
    //Ovveride keyword - we use this when implementing our abstract/ changing our virtual methods
    public override void Move()
    {
        Console.WriteLine("Dog runs!");
    }
}
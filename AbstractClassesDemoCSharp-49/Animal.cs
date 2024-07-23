namespace AbstractClassesDemoCSharp_49;

public abstract class Animal
{
    public int Age { get; set; }
    public string Diet { get; set; }
    
    //Abstract methods (stubbed out methods)
    public abstract void Move();
    
    //Virual methods (non stubbed out methods)
    public virtual void Breathe()
    {
        Console.WriteLine("Animal is breathing!");
    }
}
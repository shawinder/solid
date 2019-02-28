using System;

// Contract says that IsSwimming must be TRUE if Swim has been called.
// This principle makes sure that every class follows the contract defined by its parent class.
public interface IDuck
{
    void Swim();
    bool IsSwimming { get; }
}
public class RealDuck : IDuck
{
    bool _isSwimming;
    public void Swim()
    {
        _isSwimming = true;
    }

    public bool IsSwimming { get { return _isSwimming; } }
}

public class ElectricDuck : IDuck
{
    public bool IsTurnedOn { get; set; }

    bool _isSwimming;

    public void Swim()
    {
        // Violation : Liskov Substituion
        // IsSwimming will be TRUE only if switch is turned on.
        if (IsTurnedOn)
        {
            _isSwimming = true;
        }
    }

    public bool IsSwimming { get { return _isSwimming; } }
}

class Program
{
    static void MakeDuckSwim(IDuck duck)
    {
        duck.Swim();
        Console.WriteLine(duck.IsSwimming);
    }

    public static void Main(string[] args)
    {
        IDuck duck1 = new RealDuck();
        MakeDuckSwim(duck1);
        IDuck duck2 = new ElectricDuck();
        MakeDuckSwim(duck2);
    }
}
using System;

// Passed : IVehicle Interface is segregated (broken) into multiple interaces (ICar, IAirplane)
public interface ICar
{
    void Drive();
}

public interface IAirplane
{
    void Fly();
}

public class Car : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving a car");
    }
}

public class Airplane : IAirplane
{
    public void Fly()
    {
        Console.WriteLine("Flying a plane");
    }
}

public class MultiFunctionalCar : ICar, IAirplane
{
    public void Drive()
    {
        Console.WriteLine("Drive a multifunctional car");
    }

    public void Fly()
    {
        Console.WriteLine("Fly a multifunctional car");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var car = new Car();
        car.Drive();
        var airplane = new Airplane();
        airplane.Fly();
        var multiCar = new MultiFunctionalCar();
        multiCar.Drive();
        multiCar.Fly();
    }
}
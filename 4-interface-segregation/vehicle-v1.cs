// ISP states that interfaces that have become “fat” (like god classes) should be split into several interfaces.
// No client should be forced to depend on methods it does not use.
using System;

public interface IVehicle
{
    void Drive();
    void Fly();
}

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a car");
    }

    // Violation : Forced to create a not-required method
    public void Fly()
    {
        Console.WriteLine("Not Implemented : Car");
    }
}

public class Airplane : IVehicle
{
    // Violation : Forced to create a non-required method
    public void Drive()
    {
        Console.WriteLine("Not Implemented : Plane");
    }

    public void Fly()
    {
        Console.WriteLine("Flying a plane");
    }
}

public class MultiFunctionalCar : IVehicle
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
    static void DriveVechicle(IVehicle vehicle)
    {
        vehicle.Drive();
        vehicle.Fly();
    }

    public static void Main(string[] args)
    {
        IVehicle vehicle1 = new Car();
        DriveVechicle(vehicle1);
        IVehicle vehicle2 = new Airplane();
        DriveVechicle(vehicle2);
        IVehicle vehicle3 = new MultiFunctionalCar();
        DriveVechicle(vehicle3);
    }
}
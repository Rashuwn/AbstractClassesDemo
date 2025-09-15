using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public bool HasTrunk { get; set; } = true;
    
    public override void DriveAbstract()
    {
        Console.WriteLine("The car is driving..");
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Has side trunk?: {HasTrunk}");
    }
    

}
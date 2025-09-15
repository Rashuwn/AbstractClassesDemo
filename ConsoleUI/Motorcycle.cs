using System;
using System.IO;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCart { get; set; } = false;

    public override void DriveAbstract()
    {
        Console.WriteLine("The motorcycle is driving..");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Motorcycle's Virtual Drive Method");
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Has Side Cart {HasSideCart}");
    }
    
    
}
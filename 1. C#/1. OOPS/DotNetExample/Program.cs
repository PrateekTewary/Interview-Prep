// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// public static void TestCars1()  
// {  
//     System.Console.WriteLine("\nTestCars1");  
//     System.Console.WriteLine("----------");  
  
//     Car car1 = new Car();  
//     car1.DescribeCar();  
//     System.Console.WriteLine("----------");  
  
//     // Notice the output from this test case. The new modifier is  
//     // used in the definition of ShowDetails in the ConvertibleCar  
//     // class.
  
//     ConvertibleCar car2 = new ConvertibleCar();  
//     car2.DescribeCar();  
//     System.Console.WriteLine("----------");  
  
//     Minivan car3 = new Minivan();  
//     car3.DescribeCar();  
//     System.Console.WriteLine("----------");  
// }

// TestCars1

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        TestCars1();
    }

    public static void TestCars1()  
    {  
        Console.WriteLine("\nTestCars1");  
        Console.WriteLine("----------");  
  
        Car car1 = new Car();  
        car1.DescribeCar();  
        Console.WriteLine("----------");  
  
        ConvertibleCar car2 = new ConvertibleCar();  
        car2.DescribeCar();  
        Console.WriteLine("----------");  
  
        Minivan car3 = new Minivan();  
        car3.DescribeCar();  
        Console.WriteLine("----------");  
    }
}

// Define the base class, Car. The class defines two methods,  
// DescribeCar and ShowDetails. DescribeCar calls ShowDetails, and each derived  
// class also defines a ShowDetails method. The example tests which version of  
// ShowDetails is selected, the base class method or the derived class method.  
class Car  
{  
    public void DescribeCar()  
    {  
        System.Console.WriteLine("Four wheels and an engine.");  
        ShowDetails();  
    }  
  
    public virtual void ShowDetails()  
    {  
        System.Console.WriteLine("Standard transportation.");  
    }  
}  
  
// Define the derived classes.  
  
// Class ConvertibleCar uses the new modifier to acknowledge that ShowDetails  
// hides the base class method.  
class ConvertibleCar : Car  
{  
    public new void ShowDetails()  
    {  
        System.Console.WriteLine("A roof that opens up.");  
    }  
}  
  
// Class Minivan uses the override modifier to specify that ShowDetails  
// extends the base class method.  
class Minivan : Car  
{  
    public override void ShowDetails()  
    {  
        System.Console.WriteLine("Carries seven people.");  
    }  
}  
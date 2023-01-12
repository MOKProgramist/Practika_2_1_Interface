// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

// Car
Car car1 = new Car(currentFuelLevel: 1.2, tankVolume: 50, registrationNumber: "м123ау799рус",  mileage: 12345, dateOfIssue: "20.04.2021", brand: "Мерседес");
car1.GetInfo();
try
{
    // Error
   // car1.Refuel(123);
    // Ok
    car1.Refuel(48);
} catch (Exception e)
{
    Console.WriteLine(e);
};

car1.GetInfo();
Console.WriteLine();
// Locomotive
Locomotive locomotive1 = new Locomotive(currentFuelLevel: 123.2, tankVolume: 500, maxSpeed: 70, dateOfIssue: "20.04.2021", model: "Метро", power: 1234);
locomotive1.GetInfo();
try
{
    // Error
    // locomotive1.Refuel(123);
    // Ok
    locomotive1.Refuel(48);
}
catch (Exception e)
{
    Console.WriteLine(e);
};

locomotive1.GetInfo();
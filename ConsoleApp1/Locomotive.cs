using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Locomotive : IFueled
    {
        public double СurrentFuelLevel { get; set; }

        public double TankVolume { get; }

        public string Model { get; }
        public double Power { get;  }

        public double MaxSpeed { get; set; }

        public string? DateOfIssue { get; }

        public Locomotive(double currentFuelLevel, double tankVolume, string model, string dateOfIssue, double power, double maxSpeed)
        {
            СurrentFuelLevel = currentFuelLevel;
            TankVolume = tankVolume;
            DateOfIssue = dateOfIssue;
            Model = model;
            Power = power;
            MaxSpeed = maxSpeed;
        }

        public void Refuel(double value)
        {
            double willFuel = value + СurrentFuelLevel;
            if (willFuel > TankVolume)
            {
                throw new Exception("Слишком много топлива, не влезет!");
            }
            Console.WriteLine($"Заправили локомотив на {value} литров, теперь у нас {willFuel} литров топлива");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Инфорация о локомотиве {Model}" +
                $"\nТопливный бак размером {TankVolume} - сейчас топлива {СurrentFuelLevel}\n" +
                $"Максимальная скорость {MaxSpeed} киллометров в час.\n" +
                $"Дата выпуска: {(String.IsNullOrEmpty(DateOfIssue) ? DateOfIssue : "Дата не указана")}");
        }
    }
}

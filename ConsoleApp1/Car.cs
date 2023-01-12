using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    internal class Car: IFueled
    {
        public double СurrentFuelLevel { get; set; }

        public double TankVolume { get; }

        public string Brand  { get; }
        public string RegistrationNumber { get; set; }

        public double Mileage { get; set; }

        public string? DateOfIssue { get; }

        public Car(double currentFuelLevel, double tankVolume, string registrationNumber, string dateOfIssue, double mileage, string brand)
        {
            СurrentFuelLevel = currentFuelLevel;
            TankVolume = tankVolume;
            RegistrationNumber = registrationNumber;
            DateOfIssue = dateOfIssue;
            Mileage = mileage;
            Brand = brand;
        }

        public void Refuel(double value)
        {
            double willFuel = value + СurrentFuelLevel;
            if (willFuel > TankVolume)
            {
                throw new Exception("Слишком много топлива, не влезет!");
            }
            Console.WriteLine($"Заправили машину на {value} литров, теперь у нас {willFuel} литров топлива");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Инфорация о машине {Brand} с рег.номером {RegistrationNumber}:" +
                $"\nТопливный бак размером {TankVolume} - сейчас топлива {СurrentFuelLevel}\n" +
                $"Пробег машины {Mileage} киллометров.\n" +
                $"Дата выпуска: {(String.IsNullOrEmpty(DateOfIssue) ? DateOfIssue : "Дата не указана")}");
        } 
    }
}

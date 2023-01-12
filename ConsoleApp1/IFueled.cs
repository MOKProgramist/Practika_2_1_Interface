using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Заправляемый топливом
    internal interface IFueled
    {
        // Текущий уровень топлива
        double СurrentFuelLevel { get;  }
        // Объем бака
        double TankVolume { get;  }

        void Refuel(double volume) {}

    }
}

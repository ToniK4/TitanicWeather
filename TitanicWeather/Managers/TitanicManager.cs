using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitanicWeather.Managers
{
    public static class TitanicManager
    {

        public static double Temp { get; set; }
        public static void SetTemp(double temp)
        {
            Temp = temp;
        }
        public static double GetTemperature()
        {
            return Temp;
        }

    }
}

using System;

namespace TempLibrary
{
    public class Temp
    {
        public double CTF(double temp)
        {
            double farhient;
            farhient = (temp * 9 / 5) + 32;
            return farhient;
        }
        public double FTC(double temp)
        {
            double celsius;
            
            celsius = (temp - 32) * 5 / 9;
            return celsius;
        }
    }
}

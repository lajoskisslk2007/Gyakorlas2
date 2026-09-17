using System;
using System.Collections.Generic;
using System.Text;

namespace Homerseklet
{
    public class homersekletAtvalto
    {
        public double Celsius;

        public double toFarenheit()
        {
            return  (Celsius * 9 / 5) + 32;
        }
        public static double CelsiusToFarenheit(double kapott)
        {
            return (kapott * 9 / 5) + 32;
        }
    }
}

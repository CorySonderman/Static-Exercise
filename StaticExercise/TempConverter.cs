using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        //Now create a static class called TempConverter. The class should have at
        //least 2 methods, one called FahrenheitToCelsius that will require a double
        //as a parameter and return a double, the other CelsiusToFahrenheit which will
        //also require a double as a parameter and return a double.
        public static double FahrenheitToCelsius(double farhenheit) 
        {
           var result = (farhenheit - 32) / 1.8;
            return result;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }

    }
}

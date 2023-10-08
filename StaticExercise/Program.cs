﻿namespace StaticExercise
{
    public class Program
    {    
        //Now create a static class called TempConverter. The class should have at
        //least 2 methods, one called FahrenheitToCelsius that will require a double
        //as a parameter and return a double, the other CelsiusToFahrenheit which will
        //also require a double as a parameter and return a double.
        //Fill out these methods and call them in your Program.cs file.Make sure
        //they’re accurate!
        static void Main(string[] args)
        {
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            var celcius = TempConverter.FahrenheitToCelsius(68);
            Console.WriteLine("--------------Conversion Results---------------");
            Console.WriteLine($"celcius: {celcius}");
            Console.WriteLine();
            Console.WriteLine($"fahrenheit: {fahrenheit}");
        }


    }
}

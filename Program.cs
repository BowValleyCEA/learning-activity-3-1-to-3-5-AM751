//LA 3.1

using System;

class ConvertingTemperature
{
    //Function to convert Celsious to Fahrenheit:
    static double CelsiousToFahrenheit(double celsious)
    {
        return (celsious * 9 / 5) + 32;
    }

    //Function to convert Fahrenheit to Celsious:
    static double FahrenheitToCelsious(double fahrenheit)
    {
        return (fahrenheit * -32) - 5 / 9;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Value of the Temperature:");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Is the Temperature in (C)elsius or (F)ahrenheit? Enter C or F:");
        string scale = Console.ReadLine().ToUpper();

        if (scale == "C")
        {
            double fahrenheit = CelsiousToFahrenheit(temperature);

            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}");
        }

        else if (scale == "F")
        {
            double celsius = FahrenheitToCelsious(temperature);

            Console.WriteLine($"Temperature in Celsius: {celsius:F2}");
        }

        else
        {
            Console.WriteLine("Invalid Scale input. Please enter C or F");
        }

    }
}
using System;

public class Conversion
{
    public static void Main()
    {
        bool run = true;

        while (run)
        {
            Console.WriteLine("Welcome to the conversion, \n Is the first unit Metric or Imperial?");
            string mes1 = Console.ReadLine();

            if (mes1.ToLower().Trim() == "metric")
            {
                Console.WriteLine("What is the unit of measurement do you wish to convert? type \"help\" if you wish to see available options");
                String unit = Console.ReadLine().Trim().ToLower();
                measurements.mDist met;
            }

            else if (mes1.ToLower().Trim() == "imperial")
            {
                int num = 0;
                string unit = "";
                measurements.mDist met;
                measurements.iDist imp;

                Console.WriteLine("What is the imperial unit of measurement do you wish to convert to metric? (\"value (space) measurement\")");
                while (unit.Equals(""))
                {
                    try
                    {
                        string input = Console.ReadLine().ToLower();
                        string[] words = input.Split(" ");
                        num = int.Parse(words[0]);
                        unit = words[1].Trim();
                    }
                    catch
                    {
                        Console.WriteLine("please follow the intended format of \"value (space) measurement\"");
                    }
                }
                imp = primaryDist(unit);
                met = SecondaryDist();

                Console.WriteLine("conversion is " + imperial.convert_dist(num, imp, met) + " " + met + "s.");
                Console.WriteLine("Would you like to do another conversion (Y/N)");
                string answer = Console.ReadLine().Trim().ToLower();

                while (!answer.Equals("yes") && !answer.Equals("no") && !answer.Equals("y") && !answer.Equals("n"))
                {
                    Console.WriteLine("Would you like to do another conversion (Y/N)");
                    answer = Console.ReadLine().Trim().ToLower();
                }
                if (answer.Equals("y") || answer.Equals("yes"))
                {
                    ;
                }
                else
                {
                    run = false;
                }
            }
            else
            {
                Console.WriteLine("Please enter one of the valid options");
                Thread.Sleep(2000);
            }
        }
    }

    public static measurements.mDist SecondaryDist()
    {

        Console.WriteLine("Which unit would you like to convert this into?");
        string unit2 = Console.ReadLine().Trim().ToLower();

        switch (unit2)
        {
            case "millimeter" or "millimeters":
                return measurements.mDist.millimeter;
            case "centimeter" or "centimeters":
                return measurements.mDist.centimeter;
            case "decimeter" or "decimeters":
                return measurements.mDist.decimenter;
            case "meter" or "meters":
                return measurements.mDist.meter;
            case "dekameter" or "dekameters":
                return measurements.mDist.dekameter;
            case "hectometer" or "hectometers":
                return measurements.mDist.hectometer;
            case "kilometer" or "kilometers":
                return measurements.mDist.kilometer;

            default:
                return SecondaryDist();
        }
    }

    public static measurements.iDist primaryDist(string unit)
    {
        switch (unit)
        {
            case "inch" or "inches":
                return measurements.iDist.inch;
            case "foot" or "feet":
                return measurements.iDist.foot;
            case "yard" or "yards":
                return measurements.iDist.yard;
            case "mile" or "miles":
                return measurements.iDist.mile;
            default:
                return primaryDist(unit);

        }
    }
}

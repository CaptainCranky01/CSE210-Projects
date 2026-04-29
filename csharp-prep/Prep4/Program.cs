using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<float> dw_numbers = new List<float>();

        float dw_sum = 0;
        float dw_lowestPositive = 0;
        float dw_highest = 0;
        float dw_average = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // collect numbers
        do
        {
            float dw_response = GetFloat("Enter Number: ");
            dw_sum += dw_response;
            // 0 is not positive or negative so it doesn't count
            dw_lowestPositive = dw_lowestPositive == 0 ? dw_response : dw_response > 0 && dw_response < dw_lowestPositive ? dw_response : dw_lowestPositive;
            dw_highest = MathF.Max(dw_response, dw_highest);

            dw_numbers.Add(dw_response);
        } while (dw_numbers[dw_numbers.Count - 1] != 0);
        dw_numbers.Sort();

        // opporate on number list
        dw_average = dw_sum / dw_numbers.Count;
        Console.WriteLine($"The sum is: {dw_sum}");
        Console.WriteLine($"The average is: {dw_average}");
        Console.WriteLine($"The largest number is: {dw_highest}");
        Console.WriteLine($"The smallest positive number is: {dw_lowestPositive}");
        Console.WriteLine("The sorted list is:");
        foreach (float dw_number in dw_numbers)
        {
            Console.WriteLine(dw_number);
        }
    }

    static float GetFloat(string prompt)
    {
        float dw_response = 0;
        bool dw_flag = true;
        while (dw_flag)
        {
            try
            {
                Console.Write(prompt);
                dw_response = float.Parse(Console.ReadLine());
                dw_flag = false;
            } catch /*(Exception e)*/ {
//                Console.WriteLine(e);
                Console.WriteLine("Invalid input! Please type a number.");
            }
        }
        return dw_response;
    }
}
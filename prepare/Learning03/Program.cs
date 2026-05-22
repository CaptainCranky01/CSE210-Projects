using System;

class Program
{
    static void Main(string[] args) {
        Random DW_RG = new Random();
        Fraction fraction = new Fraction();

        for (int i = 0; i < 20; i++) {
            fraction.SetTop(DW_RG.Next(0, 10));
            fraction.SetBottom(DW_RG.Next(0, 10));
            //Console.WriteLine($"Fraction {i}: Top: {fraction.GetTop()} Bottom: {fraction.GetBottom()}");
            Console.WriteLine($"Fraction {i}: String: {fraction.GetFractionString()} Number: {fraction.GetDecimalValue()}");
        }

        Fraction fraction1 = new Fraction(10);
        Fraction fraction2 = new Fraction(4, 10);

        Console.WriteLine($"TestFractions: fraction1: {fraction1.GetFractionString()} fraction2: {fraction2.GetFractionString()}");
    }
}
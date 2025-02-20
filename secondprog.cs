using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        string binary = "";

        while (num > 0)
        {
            int remainder = num % 2; // Get remainder when divided by 2
            binary = remainder + binary; // Append remainder at the beginning
            num /= 2; // Divide number by 2
        }

        Console.WriteLine("Binary representation: " + (binary == "" ? "0" : binary));
    }
}
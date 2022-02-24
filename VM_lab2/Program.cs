using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RomanNumber r1 = new RomanNumber(8); RomanNumber r2 = new RomanNumber(20); RomanNumber r3 = new RomanNumber(18); RomanNumber r4 = new RomanNumber(14); RomanNumber r5 = new RomanNumber(9); RomanNumber r6 = new RomanNumber(62);
                Console.WriteLine($"{r2.ToString()} + {r6.ToString()} = {RomanNumber.Add(r2, r6).ToString()} \n");
                Console.WriteLine($"{r3.ToString()} / {r5.ToString()} = {RomanNumber.Div(r3, r5).ToString()} \n");
                Console.WriteLine($"{r6.ToString()} - {r5.ToString()} = {RomanNumber.Sub(r6, r5).ToString()} \n");
                Console.WriteLine($"{r1.ToString()} * {r5.ToString()} = {RomanNumber.Mul(r1, r5).ToString()} \n");
                RomanNumber[] r = { r1, r2, r3, r4, r5, r6 };
                Array.Sort(r);
                Console.WriteLine("Sorting: \n");
                foreach (var item in r)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            catch (RomanNumberException ex)
            {
                Console.WriteLine($": {ex.Message}");
            }

        }
    }
}
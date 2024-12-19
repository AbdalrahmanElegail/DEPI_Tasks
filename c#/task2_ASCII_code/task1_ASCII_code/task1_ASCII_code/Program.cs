using System;
namespace task1_ASCII_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ch ---- ASCII  | ch ---- ASCII \n---------------|--------------");
            for (int ch = 'A'; ch <= 'Z'; ch++)
            {
                Console.WriteLine($"{(char)ch}       {(int)ch}     | {(char)(ch + 32)}       {(int)(ch + 32)}");
            }
            Console.ReadKey();
        }
    }
}

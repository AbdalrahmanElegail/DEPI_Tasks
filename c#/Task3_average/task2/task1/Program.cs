using System.ComponentModel;
using System.ComponentModel.Design;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Press Enter To Start Calculating The Average------"); Console.ReadLine();

            double[] arr = new double[9999];
            int counter = 0;
            double sum = 0;
            foreach (int i in Enumerable.Range(0,9999)) 
            {
                switch (i)
                {
                    case 0: Console.Write("Enter The 1st Element Of The Array: "); break;
                    case 1: Console.Write("Press t To Terminate Or Enter The 2nd Element Of The Array: "); break;
                    case 2: Console.Write("Press t To Terminate Or Enter The 3rd Element Of The Array: "); break;
                    default: Console.Write($"Press t To Terminate Or Enter The {i+1}th Element Of The Array: "); break;
                }
                string inputt =Console.ReadLine();
                if (inputt == "t") { Console.WriteLine($"\nThe Total Average Is: {sum/counter}\nThank you.."); break; }
                else if (!double.TryParse(inputt, out arr[i])) Console.WriteLine("Invalid input..\n");
                else
                {
                    sum += arr[i];
                    counter++;
                    Console.WriteLine($"The Average Till Now Is: {sum / counter} \n");
                }        
            }
            Console.ReadLine();
        }
    }
}

namespace _3_methods
{
    public static class Operations
    {
        public static void Welcome() => Console.WriteLine("Welcome...\n");
        public static void GreetUser(string firstName, string lastName) => Console.WriteLine($"Hello Mr: {firstName} {lastName} ...\n");
        public static int SumOf(int num1, int num2) => num1 + num2;
    }

    internal class Program
    {       
        static void Main(string[] args)
        {
            Operations.Welcome();

            string firstName= Input("Enter the first name: ");
            string lastName = Input("Enter the last name: ");
            Operations.GreetUser(firstName, lastName);

            int num1 = IntInput("Enter the 1st number to sum: ");
            int num2 = IntInput("Enter the 2nd number to sum: ");
            Console.WriteLine( $"{num1}+{num2}={Operations.SumOf(num1, num2)}");

            Console.ReadKey();
        }

        static string Input(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var str = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(str) && !int.TryParse(str, out int num))
                {
                    return str;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid Name.");
                }
            }
        }
        static int IntInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}

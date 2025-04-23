namespace cSharpFundamentals.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many large mat ..?  (if you dont have type -> 0)");

            int? large =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many small mat ..? (if you dont have type -> 0)");

            int? small = Convert.ToInt32(Console.ReadLine());

            double? result = ((large * 70) + (small * 35)) - .06;

            Console.WriteLine($"=====================================\n your Amount  is  ${result}");

        }

    }
}

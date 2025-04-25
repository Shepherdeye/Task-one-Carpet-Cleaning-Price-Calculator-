namespace cSharpFundamentals.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service ..!\n");

            Console.WriteLine("Enter Number of small carpet ..? ");

            int? small = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of large carpet ..? ");

            int? large = Convert.ToInt32(Console.ReadLine());

            double? result = large * 35 + small * 25 + 6.6;

            int? cost = large * 35 + small * 25;

            Console.WriteLine("\n");

            double tax = 6.6;

            Console.WriteLine($"cost : {cost:C}");
            Console.WriteLine($"Tax : {tax:C}");

            Console.WriteLine($"=====================================\n Total estimate : {result:C} \n This estimate is valid for 30 days");




        }

    }
}
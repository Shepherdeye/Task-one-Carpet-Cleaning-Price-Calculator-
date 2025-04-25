namespace cSharpFundamentals.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service ..!\n");

            Console.WriteLine("Enter Number of small carpet ..?");

            int? small = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of large carpet ..?");

            int? large = Convert.ToInt32(Console.ReadLine());

            double tax = 6.6;

            double? result = large * 35 + small * 25 + tax;

            int? cost = large * 35 + small * 25;

            Console.WriteLine("\n");


            Console.WriteLine("cost : $"+cost);
            Console.WriteLine("Tax : $"+tax);
            Console.WriteLine($"=====================================\n Total estimate : ${result} \n This estimate is valid for 30 days");
        }

    }
}
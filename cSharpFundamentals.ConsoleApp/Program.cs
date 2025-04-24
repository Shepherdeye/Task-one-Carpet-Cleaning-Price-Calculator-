namespace cSharpFundamentals.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to islam carpet clean service ..!\n");
            
            

            Console.WriteLine("Enter Number of small carpet ..?  (if you dont have small carpet type number 0)");

            int? small = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of large carpet ..? (if you dont have large carpet type number 0)");

            int? large =Convert.ToInt32(Console.ReadLine());

            double? result = large * 35 + small * 25 + 6.6;

            int? cost = large * 35 + small * 25;

            Console.WriteLine("\n");

            double tax = 6.6;

            Console.WriteLine("cost : $" + cost);
            Console.WriteLine("Tax : $" + tax);
      
            Console.WriteLine($"=====================================\n Total estimate : ${result} \n This estimate is valid for 30 days");

        }

    }
}

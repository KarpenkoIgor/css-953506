using System;

namespace Lab3Ind1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! Enter the data of your transport!\n");

            Console.Write("First of all, the transport's type: ");
            string Type = Console.ReadLine();

            Console.Write("\nNow, enter it's mark: ");
            string Mark = Console.ReadLine();

            Console.Write("\nThe year your vehicle was made: ");
            uint Year;
            bool success;
            do
            {
                success = UInt32.TryParse(Console.ReadLine(), out Year);
                if(!success)
                    Console.Write("Error. Please, enter the year once again: ");
                else
                    Console.WriteLine("Okay!\n");
            } while (success == false);

            Console.Write("Your transport's capacity: ");
            uint Capacity;
            do
            {
                success = UInt32.TryParse(Console.ReadLine(), out Capacity);
                if (!success)
                    Console.Write("Error. Please, enter the capacity once again: ");
                else
                    Console.WriteLine("Okay!\n");
            } while (success == false);

            Console.Write("Now, the vehicle's power: ");
            uint Power;
            do
            {
                success = UInt32.TryParse(Console.ReadLine(), out Power);
                if (!success)
                    Console.Write("Error. Please, enter the capacity once again: ");
                else
                    Console.WriteLine("Okay!\n");
            } while (success == false);

            Console.Write("And, the vehicle's maximum speed: ");
            uint Max;
            do
            {
                success = UInt32.TryParse(Console.ReadLine(), out Max);
                if (!success)
                    Console.Write("Error. Please, enter the capacity once again: ");
                else
                    Console.WriteLine("Okay!\n");
            } while (success == false);

            Transport Vehicle = new Transport(Type, Mark, Year, Capacity, Power, Max);
        }
    }
}

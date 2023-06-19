using System;

namespace Temp_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal temperature = 0;
            char answer = 'A';
            bool correct = false;

            while(!correct)
            {
                try
                {
                    Console.Write("Please enter a temperature: ");
                    temperature = Convert.ToDecimal(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("You must enter a number!");
                }
            }

            do
            {
                Console.Write("Do you want to convert to Fahrenheit(F) or Celsius(C)? ");
                answer = char.ToUpper (Console.ReadKey().KeyChar);
                Console.WriteLine();
            } while(answer != 'F' && answer != 'C');       
           
            if (answer == 'F')
            {
                temperature = (temperature + 32m) * (5m / 9m);
                Console.WriteLine("Temperature in fahrenheit is: " + temperature);
            }
            else if (answer == 'C')
            {
                temperature = (temperature - 32m) * (9m / 5m);
                Console.WriteLine("Temperature in Celsius is: " + temperature);
            }
            

           
            Console.ReadLine();
        }
    }
}

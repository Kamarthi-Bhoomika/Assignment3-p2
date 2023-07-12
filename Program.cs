using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                Console.WriteLine("Converted to Integer " + value);
                Console.WriteLine($"Resulting value after multiplying by 5 = {value * 5}");
            }
            else
            {
                Console.WriteLine("Failed to Parse");
            }
            Console.ReadKey();

            try
            {
                Console.WriteLine("Enter a Date");
                string input2 = Console.ReadLine();
                Convert.ToDateTime(input2);
                Console.WriteLine("Converted to DateTime " + input2);
                DateTime sub = Convert.ToDateTime(input2);
                Console.WriteLine("After subtracting 1 month "+sub.AddMonths(-1));

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format Exception " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow exception " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }


            try
            {
                Console.WriteLine("Enter a Number");
                string input3 = Console.ReadLine();
                TimeSpan.Parse(input3);
                Console.WriteLine("Parsed Number " + input3);
                TimeSpan add = TimeSpan.FromHours(2);
                Console.WriteLine("After adding 2hrs "+add);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program");
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[2];
            try
            {
                numbers[0] = 23;
                numbers[1] = 32;
                numbers[2] = 42;

                foreach (int i in numbers)
                    Console.WriteLine(i);

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("An index was out of the range");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went very wrong");
                Console.WriteLine("The error was: " + ex.Message);
                Console.WriteLine("The type of message was: " + ex.GetType().ToString());

            }
            finally
            {
                Console.WriteLine("It's the end of our try block. Time to clean up!");
            }
            Console.ReadKey();
        }
    }
}

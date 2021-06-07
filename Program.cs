using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int result = num1 / num2;
                Console.WriteLine("The result is :" + result);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            finally
            {
                Console.WriteLine("Application Completed");
            }
        }
    }
}

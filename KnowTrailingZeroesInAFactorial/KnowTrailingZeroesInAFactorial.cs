using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailingZeroes
{
    class KnowTrailingZeroesInAFactorial
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the base of the number system");
                int n_base = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number in this base");
                int number = Convert.ToInt32(Console.ReadLine());
                GetTrailingZeroes Trailing_Zeroes_Object = new GetTrailingZeroes();
                int answer = Trailing_Zeroes_Object.NumberOfZeroesInFactorial(Trailing_Zeroes_Object.GetDecimalRepresentation(number, n_base));

                Console.WriteLine("Answer is {0} zeroes", answer);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid input");
                Main(args);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockPositionsOnAGivenAngel
{
    class Program
    {
        static void Main(string[] args)
        {
            int Mins, Hrs,Angle,MinutesToBeAdded, Counter;
            Mins = Hrs = MinutesToBeAdded= Counter=0;
            Console.WriteLine("Input the angle");
            Angle =(Math.Abs(Convert.ToInt32(Console.ReadLine()))) % 180;
            while(Counter<12)
            {
                if (Counter % 2 == 0)
                {
                    MinutesToBeAdded = Angle / 6;
                    Hrs += MinutesToBeAdded / 60;
                    Mins += MinutesToBeAdded % 60;
                    Hrs += Mins / 60;
                    Mins = Mins % 60;
                    Console.WriteLine(Hrs + ":" + (Mins.ToString().Length==1 ?"0":"")+ Mins);
                }
                else
                {
                    MinutesToBeAdded = ((360 - Angle) / 6) - MinutesToBeAdded;
                    Mins += MinutesToBeAdded;
                    Hrs += Mins / 60;
                    Mins = Mins % 60;
                    Console.WriteLine(Hrs+ ":" + (Mins.ToString().Length == 1 ? "0" : "") + Mins);
                    Mins = (Counter-1)*5;
                    Hrs++;
                }
                Counter++;
            }
            Console.ReadKey();
        }
    }
}

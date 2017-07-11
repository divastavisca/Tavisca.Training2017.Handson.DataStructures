using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailingZeroes
{
    public class GetTrailingZeroes
    {
        public int NumberOfZeroesInFactorial(int number)
        {
            int temp,count=0;
            for(int i=1;i<=number;i++)
            {
                temp = i;
                while(temp%5==0)
                {
                    count++;
                    temp /= 5;
                }
            }
            return (count);
        }

        public int GetDecimalRepresentation(int number,int num_base)
        {
            int final_value=0,temp=0,level=0;
            while(number>0)
            {
                temp = number % 10;
                final_value += (int)Math.Pow(num_base, level++) * temp;
                number /= 10;
            }
            return (final_value);
        }

    }
}

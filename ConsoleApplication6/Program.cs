using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CowCounter(45));
        }

        public static string CowCounter(int n)
        {
            int lastDigit = n % 10;
            int last2Digits = n % 100;
            int lastlast = last2Digits % 10;
            string result = string.Empty;

            if (11 <= last2Digits && last2Digits <= 19)
                result = "Коров";
            else if (last2Digits == 01)
                result = "Корова";
            else if (lastDigit == 1 && last2Digits != 11)
                result = "Корова";
            else if (2 <= lastDigit && lastDigit <= 4)
                result = "Коровы";
            else if (5 <= lastDigit && lastDigit <= 9 || lastDigit == 0 || last2Digits == 11 )
                result = "Коров";
            
            
            return string.Format("{0} {1}", n, result);

        }
    }
}

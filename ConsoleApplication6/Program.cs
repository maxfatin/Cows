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
            
        }

        public static string CowCounter(int n)
        {
            int lastDigit = n % 10;
            int last2Digits = n % 100;
            int lastlast = last2Digits % 10;
            string result = string.Empty;

            if (11 <= last2Digits && last2Digits <= 19)
                result = "коров";
            else if (last2Digits == 01)
                result = "корова";
            else if (lastDigit == 1 && last2Digits != 11)
                result = "корова";
            else if (2 <= lastDigit && lastDigit <= 4)
                result = "коровы";
            else if (5 <= lastDigit && lastDigit <= 9 || lastDigit == 0 || last2Digits == 11 )
                result = "коров";
            
            
            return string.Format("{0} {1}", n, result);

        }
    }
}

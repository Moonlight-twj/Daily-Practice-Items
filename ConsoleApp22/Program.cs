using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    public static int DaysDifferent(string dateS1, string dateS2, string format)
    {
        try
        {
            DateTime date1 = DateTime.ParseExact(dateS1, format, CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(dateS2, format, CultureInfo.InvariantCulture);
            return Math.Abs((date2 - date1).Days);
        }
        catch (FormatException)
        {
            Console.WriteLine("日期格式不正确，请使用{0}格式", format);
            return -1;
        }
    }
    public 
        static void Main(string[] args)
        {
        }
    }
}

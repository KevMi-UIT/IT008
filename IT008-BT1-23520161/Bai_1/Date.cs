using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    
    public class Date( int month = 1, int year = 1)
    {
        private static readonly int[] daysInMonthLeap = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] daysInMonthNoLeap = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int month { get; set; } = month;
        private int year { get; set; } = year;

        public void Input()
        {
            Console.Write("Nhap thang: ");
            this.month = int.Parse(Console.ReadLine() ?? "1");
            Console.Write("Nhap nam: ");
            this.year = int.Parse(Console.ReadLine() ?? "1");
        }

        private static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        private int getDaysInMonth()
        {
            if (this.month < 1 || this.month > 12)
                throw new IndexOutOfRangeException("Month is not valid");
            if (Date.IsLeapYear(this.year))
                return Date.daysInMonthLeap[this.month - 1];
            return Date.daysInMonthNoLeap[this.month - 1];
        }

        public void check()
        {
            try
            {
                Console.WriteLine($"So ngay trong thang {this.month} la: {this.getDaysInMonth()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;
using System.Globalization;

namespace Bai01;

class Program
{
    static int year = new();
    static int month = new();
    static readonly int[,] calendar = new int[6, 7];
    private static DateTime date;

    static void Main()
    {
        Console.Write("Nhap nam: ");
        year = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhap thang [1, 12]: ");
        month = int.Parse(Console.ReadLine() ?? "0");

        date = new DateTime(year, month, 1);
        DrawHeader();
        FillCalendar();
        DrawCalendar();
    }

    static void DrawHeader()
    {
        Console.WriteLine("");
        Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month) + " " + year);
        Console.WriteLine("Mo Tu We Th Fr Sa Su");
    }

    static void FillCalendar()
    {
        int days = DateTime.DaysInMonth(year, month);
        int currentDay = 1;
        var dayOfWeek = (int)date.DayOfWeek;
        for (int i = 0; i < calendar.GetLength(0); i++)
        {
            for (int j = 0; j < calendar.GetLength(1) && currentDay - dayOfWeek + 1 <= days; j++)
            {
                if (i == 0 && month > j)
                {
                    calendar[i, j] = 0;
                }
                else
                {
                    calendar[i, j] = currentDay - dayOfWeek + 1;
                    currentDay++;
                }
            }
        }
    }

    static void DrawCalendar()
    {
        for (int i = 0; i < calendar.GetLength(0); i++)
        {
            for (int j = 0; j < calendar.GetLength(1); j++)
            {
                if (calendar[i, j] > 0)
                {
                    if (calendar[i, j] < 10)
                    {
                        Console.Write(" " + calendar[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(calendar[i, j] + " ");
                    }
                }
                else
                {
                    Console.Write("   ");
                }
            }
            Console.WriteLine("");
        }
    }
}

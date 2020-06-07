using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        struct Time
        {
            public int hour;
            public int minute;
            public int second;
        }
        struct Date
        {
            public int day;
            public int month;
            public int year;
        }


        static void Main(string[] args)
        {
            Time time;
            Date date;
            int[] arrayTime = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] arrayDate = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            DateTime now = DateTime.Now;
            Console.Write(now.ToString("HH:mm:ss"));
            Console.WriteLine(" " + now.ToString("dd.MM.yyyy") + " / " + now.ToString("dd MMMM yyyy"));
            time.hour = int.Parse(now.ToString("HH"));
            time.minute = int.Parse(now.ToString("mm"));
            time.second = int.Parse(now.ToString("ss"));
            arrayTime[time.hour / 10]++;
            arrayTime[time.hour % 10]++;
            arrayTime[time.minute / 10]++;
            arrayTime[time.minute % 10]++;
            arrayTime[time.second / 10]++;
            arrayTime[time.second % 10]++;
            Console.WriteLine("For time: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " = " + arrayTime[i] + "; "); ;
            }

            date.day = int.Parse(now.ToString("dd"));
            date.month = int.Parse(now.ToString("MM"));
            date.year = int.Parse(now.ToString("yyyy"));
            arrayDate[date.day / 10]++;
            arrayDate[date.day % 10]++;
            arrayDate[date.month / 10]++;
            arrayDate[date.month % 10]++;
            arrayDate[date.year / 1000]++;
            arrayDate[date.year / 100 % 10]++;
            arrayDate[date.year / 10 % 100]++;
            arrayDate[date.year % 10]++;
            Console.WriteLine("\nFor date: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " = " + arrayDate[i] + "; ");
            }

            Console.ReadKey();
        }
    }
}

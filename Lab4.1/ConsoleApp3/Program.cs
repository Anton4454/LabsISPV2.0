using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    class Program
    {
        [DllImport("DLL2.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Add(int a, int b);

        [DllImport("DLL2.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Subtract(int a, int b);

        [DllImport("DLL2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Multiply(int a, int b);

        [DllImport("DLL2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern float Division(float a, float b);

        [DllImport("DLL2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int GCD(int a, int b);

        [DllImport("DLL2.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int LCM(int a, int b);

        [DllImport("DLL2.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Power(int a, int b);

        static void Main(string[] args)
        {
            int a, b; int f = 1;
            Console.Write("Введите 1-ое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2-ое число: ");
            b = Convert.ToInt32(Console.ReadLine());
            while (f == 1)
            {
                Console.Write("Введите Действие :\n1.Сложение\n2.Вычитание\n3.Умножение\n4.Деление\n5.НОД чисел\n6.НОК чисел\n7.Возведение в степень\n8.Выйти\n");
                string x = Console.ReadLine();
                double answer = 0;
                switch (x)
                {
                    case "1":
                        answer = Add(a, b);
                        Console.WriteLine($"The answer is: {answer}");
                        break;
                    case "2":
                        answer = Subtract(a, b);
                        Console.WriteLine($"The answer is: {answer}");
                        break;
                    case "3":
                        answer = Multiply(a, b);
                        Console.WriteLine($"The answer is: {answer}");
                        break;
                    case "4":
                        float x1 = (float)a;
                        float y1 = (float)b;
                        answer = Division(x1, y1);
                        Console.WriteLine($"The answer is: {answer}");
                        break;
                    case "5":
                        answer = GCD(a, b);
                        Console.WriteLine($"The answer is: {answer}");
                        break;
                    case "6":
                        answer = LCM(a, b);
                        Console.WriteLine($"The answer is: {answer}");
                        break;
                    case "7":
                        answer = Power(a, b);
                        Console.WriteLine($"The answer is: {answer}");
                        break;
                    default:
                        return;
                }
            }
        }
    }
}



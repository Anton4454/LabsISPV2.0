using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testring of constructor
            Console.WriteLine("\nConstructor tests: \n");
            Rational x = new Rational(4,5);
            Console.WriteLine(x);
            //x = new Rational(2, 0);
            //Console.WriteLine(x);
            
            //Testing of parsing from different string formats
            Console.WriteLine(Rational.Parse("4/5"));
            Console.WriteLine(Rational.Parse("1"));
            Console.WriteLine(Rational.Parse("-1.5"));

            //Testing of operators
            Rational b = new Rational(5, 2);
            Rational a = new Rational(5, 1);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            //Testing of convert methods

            Console.WriteLine((int)b);
            Console.WriteLine((long)b);
            Console.WriteLine((decimal)b);
            Console.WriteLine((double)b);
            Console.WriteLine((float)b);

            int Int = 5; x = Int;
            Console.WriteLine(x);
            int Long = 5; x = Long;
            Console.WriteLine(x);
            double Double = 5.2; x = Double;
            Console.WriteLine(x);
            decimal Decimal = 5.2m; x = Decimal;
            Console.WriteLine(x);
            
            Console.WriteLine(b.ToString("USUAL", null));
            Console.WriteLine(b.ToString("FLOAT", null));
            Console.WriteLine(b.ToString("INT", null));
            Console.WriteLine(Rational.Parse("10/3"));
            Console.WriteLine(Rational.Parse("5"));
            Console.WriteLine(Rational.Parse("5,2"));
        }
    }
}

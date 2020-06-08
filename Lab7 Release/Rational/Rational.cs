using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Rational
{
    class Rational : IComparable<Rational>, IEquatable<Rational>, IFormattable
    {
        public long Numerator { get; private set; }
        public long Denominator { get; private set; }
        public Rational(long numerator, long denominator)
        {
            Numerator = numerator;
            if (denominator > 0) Denominator = denominator;
            else Denominator = 1;
            Reduce();
        }

        //Convertation

        public static implicit operator Rational(long x)
        {
            return new Rational(x, 1);
        }
        public static implicit operator Rational(int x)
        {
            return new Rational((long)x, 1);
        }
        public static implicit operator Rational(double x)
        {
            return Make(x);
        }
        public static implicit operator Rational(decimal x)
        {
            return Make((double)x);
        }
        public static Rational Make(double x)
        {
            string current = x.ToString();int pos = current.IndexOf(",");
            try
            {
                int a = Convert.ToInt32(current.Substring(0, pos));
                string s = "0" + current.Substring(pos, current.Length-1);
                double b = Convert.ToDouble(s);
                b *= (int)Math.Pow(10, x.ToString().Length - 2);
                long number = (long)(a * (long)Math.Pow(10, s.ToString().Length - 2) + b);
                return new Rational(number, (long)Math.Pow(10, s.ToString().Length - 2));
            }
            catch
            {
                return new Rational((long)x, 1);
            }
        }
        public static explicit operator long(Rational x)
        {
            return (x.Numerator / x.Denominator);
        }
        public static explicit operator int(Rational x)
        {
            int a = (int)x.Numerator;
            int b = (int)x.Denominator;
            return (a / b);
        }
        public static explicit operator float(Rational value)
        {
            float a = (float)value.Numerator;
            float b = (float)value.Denominator;
            return (a / b);
        }
        public static explicit operator double(Rational value)
        {
            double a = (double)value.Numerator;
            double b = (double)value.Denominator;
            return (a / b);
        }
        public static explicit operator decimal(Rational value)
        {
            decimal a = (decimal)value.Numerator;
            decimal b = (decimal)value.Denominator;
            return (a / b);
        }
        public void Reduce()
        {
            long gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }

        // Math Operations

        public static Rational operator +(Rational a, Rational b)
        {
            long numerator = (a.Numerator * b.Denominator) + (b.Numerator * a.Denominator);
            long denominator = a.Denominator * b.Denominator;
            return new Rational(numerator, denominator);
        }
        public static Rational operator -(Rational a, Rational b)
        {
            long numerator = (a.Numerator * b.Denominator) - (b.Numerator * a.Denominator);
            long denominator = a.Denominator * b.Denominator;
            return new Rational(numerator, denominator);
        }
        public static Rational operator *(Rational a, Rational b)
        {
            long numerator = a.Numerator * b.Numerator;
            long denominator = a.Denominator * b.Denominator;
            return new Rational(numerator, denominator);
        }
        public static Rational operator /(Rational a, Rational b)
        {
            long numerator = a.Numerator * b.Denominator;
            long denominator = 0;
            try
            {
                if (b.Numerator != 0) denominator = b.Numerator * a.Denominator;
            }
            catch
            {
                throw new DivideByZeroException();
            }
            return new Rational(numerator, denominator);
        }
        public static bool operator <(Rational a, Rational b)
        {
            return a.CompareTo(b) == -1;
        }
        public static bool operator >(Rational a, Rational b)
        {
            return a.CompareTo(b) == 1;
        }
        public static bool operator ==(Rational a, Rational b)
        {
            return a.CompareTo(b) == 0;
        }
        public static bool operator !=(Rational a, Rational b)
        {
            return a.CompareTo(b) != 0;
        }
        public static bool operator <=(Rational a, Rational b)
        {
            return a.CompareTo(b) != 1;
        }
        public static bool operator >=(Rational a, Rational b)
        {
            return a.CompareTo(b) != -1;
        }
        public static Rational operator ++(Rational a)
        {
            return a + 1;
        }
        public static Rational operator --(Rational a)
        {
            return a - 1;
        }
        public static bool operator true(Rational a)
        {
            return a.Numerator != 0;
        }
        public static bool operator false(Rational a)
        {
            return a.Numerator == 0;
        }
        public static Rational operator -(Rational a)
        {
            return new Rational(-a.Numerator, a.Denominator);
        }
        public static Rational operator +(Rational a)
        {
            return new Rational(Math.Abs(a.Numerator), a.Denominator);
        }
        public bool Equals(Rational other)
        {
            return this.CompareTo(other) == 0;
        }
        public int CompareTo(Rational x)
        {
            long lcm = LCM(Denominator, x.Denominator);
            long a = Numerator * (lcm / Denominator);
            long b = x.Numerator * (lcm / x.Denominator);
            if (a < b) return -1;
            else if (a > b) return 1;
            else return 0;
        }
        public static long GCD(long a, long b)
        {
            long a1 = a;
            long b1 = b;
            while (b1 != 0)
            {
                a1 %= b1;
                long x = a1;
                a1 = b1;
                b1 = x;
            }
            return a1;
        }
        public static long LCM(long a, long b)
        {
            long ans = a / GCD(a, b) * b;
            return ans;
        }

        // Work with strings

        public static Rational Parse(string s)
        {
            if (TryParse(s, out Rational number)) return number;
            else throw new FormatException("ERROR");
        }
        public static bool TryParse(string s, out Rational number)
        {
            number = null;
            Regex pattern1 = new Regex(@"^(-?\d+)/(\d+)$");
            Regex pattern2 = new Regex(@"^(-?\d+)$");
            Regex pattern3 = new Regex(@"^(-?\d+)[,\.](\d+)$");
            if (pattern1.IsMatch(s))
            {
                Match match = pattern1.Match(s);
                number = new Rational(long.Parse(match.Groups[1].Value), long.Parse(match.Groups[2].Value));
                return true;
            }
            if (pattern2.IsMatch(s))
            {
                Match match = pattern2.Match(s);
                number = new Rational(long.Parse(match.Groups[1].Value), 0);
                return true;
            }
            if (pattern3.IsMatch(s))
            {
                Match match = pattern3.Match(s);
                long cur = long.Parse(match.Groups[1].Value);

                string floating = match.Groups[2].Value;
                long floatpart = (long)Math.Pow(10, floating.Length);
                if (cur > 0) number = new Rational((cur) * floatpart + long.Parse(floating), floatpart);
                else number = new Rational((cur) * floatpart + long.Parse(floating) * (-1), floatpart);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return this.ToString(null, CultureInfo.CurrentCulture);
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format)) format = "USUAL";
            if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;
            switch (format.ToUpperInvariant())
            {
                case "USUAL":
                    return Numerator.ToString() + '/' + Denominator.ToString();
                case "FLOAT":
                    return ((decimal)this).ToString();
                case "INT":
                    return ((long)this).ToString();
                default:
                    throw new FormatException(String.Format("The '{0}' format string is not supported.", format));
            }
        }
    }
}
     

            
            
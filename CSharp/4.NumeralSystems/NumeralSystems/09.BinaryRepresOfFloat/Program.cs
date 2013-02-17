using System;

    class BinaryRepresOfFloat
    {
        static string Base10ToBase2Integer(int d)
        {
            string b = String.Empty;
            for (; d != 0; d /= 2) b = d % 2 + b;
            return b;
        }

        static string Base10ToBase2Fraction(float f)
        {
            string b = String.Empty;
            for (f *= 2; f != 0; f *= 2)
            {
                b += (int)f;
                f -= (int)f;
            }
            return b;
        }

        static int GetSign(float f)
        {
            return f < 0 ? 1 : 0;
        }

        static string GetExponent(string integer, string fraction)
        {
            int exponent;
            if (integer.Length != 0) exponent = integer.Length - 1;
            else exponent = -fraction.IndexOf('1') - 1;
            return Base10ToBase2Integer(127 + exponent).PadLeft(8, '0');
        }

        static string GetMantissa(string integer, string fraction)
        {
            string mantissa;
            if (integer.Length != 0) mantissa = integer.Substring(1) + fraction;
            else mantissa = fraction.Substring(fraction.IndexOf('1') + 1);
            return mantissa.PadRight(23, '0');
        }

        static void Main(string[] args)
        {
            float f = -27.25f; 
            int sign = GetSign(f);
            f = Math.Abs(f);

            string integer = Base10ToBase2Integer((int)f);
            string fraction = Base10ToBase2Fraction(f - (int)f);

            Console.WriteLine(sign);
            Console.WriteLine(GetExponent(integer, fraction));
            Console.WriteLine(GetMantissa(integer, fraction));
    }
}
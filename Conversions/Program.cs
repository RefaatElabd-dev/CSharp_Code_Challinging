using System;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100000007;
            Console.WriteLine(i);
            float f = i;
            Console.WriteLine(f);
            int i2 = (int)f;
            Console.WriteLine(i2);
            Console.ReadKey();

            int l = 100000004;
            Console.WriteLine(l);
            float f2 = l;
            Console.WriteLine(f2);
            long l2 = (long)f2;
            Console.WriteLine(l2);
            Console.ReadKey();

            //Checked operator

            int a = 1000000, b = 1000000;
            Console.WriteLine((a * b));

            Console.WriteLine("############  Special floating point values  ##########");
            Console.WriteLine(double.NaN);
            Console.WriteLine(1.0 / 0.0); // Infinity
            Console.WriteLine(-1.0 / 0.0); // -Infinity
            Console.WriteLine(1.0 / -0.0); // -Infinity
            Console.WriteLine(-1.0 / -0.0); // Infinity
            Console.WriteLine(0.0 / 0.0); // NaN
            Console.WriteLine((1.0 / 0.0) - (1.0 / 0.0)); // NaN

            Console.WriteLine(0.0 / 0.0 == double.NaN); // False
            Console.ReadKey();


            Console.WriteLine("############  Casting issues with small memory predefined Types ##########");

            short x = 3;
            short y = 7;

            //short z = x + y;  issue as + op by default return int
            short z = (short) (x + y);
            Console.WriteLine(z);
            Console.ReadKey();


            Console.WriteLine("############  Shift Operators  ##########");

            Console.WriteLine("############  Lift  ##########");
            int lOP = 0b0101_0011_0000_0100_1101_0011_0000_0000;
            int aLOP = lOP << 2;
            Console.WriteLine(lOP);
            Console.WriteLine(Convert.ToString(lOP, toBase: 2));
            Console.WriteLine(aLOP);
            Console.WriteLine(Convert.ToString(aLOP, toBase: 2));

            Console.WriteLine("############  Right  ##########");
            int rOP = 0b1101_0011_0000_0100;
            int aROP = rOP >> 2;
            Console.WriteLine(rOP);
            Console.WriteLine(Convert.ToString(rOP, toBase: 2));
            Console.WriteLine(aROP);
            Console.WriteLine(Convert.ToString(aROP, toBase: 2));

            Console.ReadKey();
        }

    }
}

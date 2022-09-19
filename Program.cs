using System;

namespace lab_1_n3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Номер 1");
            int a = 2; int b = 3; int c = 15;

            double p1 = Math.Sqrt((Math.Pow(a, 2) - Math.Pow(b, 3)
            /
            Math.Sqrt(Math.Pow(b, 4) - Math.Pow(a, 4))) + Math.Abs(Math.Pow(b, 5) - Math.Pow(c, 2.5)));

            Console.WriteLine(p1);


            Console.WriteLine("Номер 2");
            Random rn = new Random();
            int b1 = rn.Next(0, 100);
            int a1 = rn.Next(0, 100);
            double c1 = (Math.Pow(a1, 2) + Math.Pow(b1, 1 / 3))
            /
            (a1 + b1);

            Console.WriteLine(c1);



            Console.WriteLine("Номер 3");
            double a2 = 5.93576;
            int b2 = (int)a2;

            int c2 = (int)Math.Round(a2);
            int d = (int)Math.Floor(a2);
            double e = Math.Round(a2, 1);
            int f = 5;
            int g1 = f++;
            int g2 = ++f;



            Console.WriteLine(b2);
            Console.WriteLine(c2);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f++);
            Console.WriteLine(++f);

            Console.WriteLine("номер 4");
            Random rn1 = new Random();
            int b3 = rn.Next(0, 100);
            Console.WriteLine(b3);


        }
    }
}

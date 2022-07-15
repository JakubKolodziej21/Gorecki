using System;

namespace Pierwsze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction();
            Fraction b = new Fraction(1, 2);
            Fraction c = new Fraction(b);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);



            //Operator +
            Console.WriteLine((b + c).ToString());

            //Operator -
            Console.WriteLine((b - c).ToString());

            //Operator *
            Console.WriteLine((b * c).ToString());

            //Operator /
            Console.WriteLine((b / c).ToString());

            //Equals
            Console.WriteLine(a.Equals(c));

            //Compare
            Fraction d = new Fraction(1, 4);
            Fraction e = new Fraction(3, 4);
            Fraction f = new Fraction(2, 5);
            Fraction g = new Fraction(2, 6);
            Fraction[] tab = new Fraction[] { d, e, f, g };




            Console.WriteLine();
            Console.WriteLine("Po posortowaniu: ");
            Console.WriteLine();

            Array.Sort(tab);


            foreach (Fraction x in tab)
            {
                Console.WriteLine(x.ToString());

            }

            //Zaokrąglanie 
            Console.WriteLine(a.toCeil());
            Console.WriteLine(a.toFloor());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierwsze
{
    public class Fraction: IEquatable<Fraction>, IComparable<Fraction>
    {
        private int numerator;
        private int denominator;

        //Domyślny

        /// <summary>
        ///    Main Constructor
        /// </summary>
        public Fraction (){
            numerator = 1;
            denominator = 1;
        
        }
        //Z dwoma argumentami

        /// <summary>
        ///  Constructor with two argues
        /// </summary>
        /// <param name="num"></param>
        /// <param name="den"></param>
        public Fraction(int num, int den) 
        {
            this.numerator = num;
            this.denominator = den;
        
        }

        //Kopiujący
        public Fraction(Fraction fraction)
        {
            numerator = fraction.numerator;
            denominator = fraction.denominator;
        }


        //ToString
        public override string ToString()
        {
            return this.numerator + " / " + this.denominator;
        }

        //Operatory
        public static Fraction operator + (Fraction a , Fraction b)
        {
            return new Fraction (a.numerator*b.denominator+b.numerator*b.denominator,a.denominator*b.denominator);
        }

        public static Fraction operator - (Fraction a, Fraction b)
        {
            return new Fraction(a.numerator * b.denominator - b.numerator * b.denominator, a.denominator * b.denominator);
        }

        public static Fraction operator * (Fraction a, Fraction b)
        {
            return new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);
        }

        public static Fraction operator / (Fraction a, Fraction b)
        {
            while(a.denominator == 0 || b.denominator == 0)
            { throw new DivideByZeroException();  }
            
            return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
        }


        //interfejs Equals
      
        public bool Equals(Fraction fraction)
        {
            return fraction.numerator == this.numerator && fraction.denominator == this.denominator;
        }

        //interfejs Compare

        public int CompareTo(Fraction other)
        {
            int result = (this.numerator * other.denominator).CompareTo(this.denominator * other.numerator);

            if (result == 0)
            {
                result = this.numerator.CompareTo(other.numerator);
            }

            return result;

        }

        //Gettery
        public int Numerator { get => numerator; }
        public int Denominator { get => denominator; }

        //Zaokrąglanie w dół

        public int toFloor()
        {
            return (int)Math.Floor(((double)numerator / (double)denominator));
        }


        //Zaokrąglanie w górę

        public int toCeil()
        {
            return (int)Math.Ceiling(((double)numerator / (double)denominator));
        }


    }
}

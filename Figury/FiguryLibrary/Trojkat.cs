using System;

namespace FiguryLibrary
{
    public class Trojkat
    {
        // definiujemy dane obiektu = pola obiektu (fields)
        private double a; // this.a
        
        public double A
        {
            get { return a; }
            set 
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartość A musi byc dodatnia");
                else
                    a = value;
            }
        }
                
        private double b; // this.b
        public double B
        {
            get => b;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartość B musi byc dodatnia");
                else
                    b = value;
            }
        }
        
        private double c; // this.c
        public double C
        {
            get => c;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartość C musi byc dodatnia");
                else
                    c = value;
            }
        }

                     
        // opisanie procesu budowy projektu / konstruktory
        public Trojkat()  // konstruktor domyśly, default
        {
            a = b = c = 1.0;
        }

        public Trojkat(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new AggregateException("Nie spełniony warunek trójkąta");
            }
            this.A = a;
            this.B = b;
            this.C = c;
        }
        // tekstowa reprezentacja obiektu
        public override string ToString()
        {
            return $"Trójkąt(a: {a}, b: {b}, c: {c})";
        }

        // właściwości i metody

        public double GetObwod() // metoda zwracająca owód tego trójkata, Java style
        {
            return a + b + c;
        }
        // property zwracające obwód tego trojkata
        public double Obwod => a + b + c;

        public double GetPole() // Java style
        {
            var p = 0.5 * GetObwod();
            var s = Math.Sqrt( p * (p-a) * (p-b) * (p-c) );
            return s;
        }

        public double Pole
        {
            get
            {
                var p = 0.5 * Obwod;
                var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
        }
    }
}

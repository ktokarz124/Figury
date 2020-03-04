using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Circle : Figure
    {
        public double R { get; private set; } // R jest read-only

        public Circle(double r = 1) : base("black")
        {
            if (r <= 0)
                throw new ArgumentOutOfRangeException("Promień musi być dodatni");

            R = r;
        }

        public virtual double Perimetr => 2 * Math.PI * R;

        public virtual double Surface => Math.PI * R * R;

        public Circle Scale(double factor)
        {
            if (factor <= 0)
                throw new ArgumentOutOfRangeException("Współczynnik skalowania musi być dodatni");
            
            return new Circle(R * factor);
        }

            public override string ToString()
        {
            return $"circle({R})";
        }

        public override void Draw()
        {
            Console.WriteLine("Rysowanie kółka");
        }
    }
}

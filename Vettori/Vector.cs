using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettori
{
    class Vector
    {
        private readonly double _x;
        private readonly double _y;

        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double X
        {
            get { return _x; }
        }

        public double Y => _y;


        public Vector Add(Vector other)
        {
            return new Vector(X + other.X, Y + other.Y);
        }

        public static Vector Parse(string s)
        {
            if (s[0] != '(')
                throw new Exception("Il vettore è sbagliato");

            string s2 = s.Substring(1, s.Length - 2);
            string[] parts = s2.Split(';');
            return new Vector(double.Parse(parts[0]), double.Parse(parts[1]));
        }

        public override string ToString()
        {
            return string.Format("({0};{1})", X, Y);
        }
    }
}

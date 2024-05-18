using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace dz_OverloadOperators
{

    class Square
    {
        public int A { get; set; }
        public Square(): this(0) { }
        public Square(int a) { A = a; }

        public override string ToString()
        {
            return $"A : {A}";
        }
        public static Square operator++(Square s)
        {
            s.A++;
            return s ;
        }
        public static Square operator--(Square s)
        { s.A--;return s ; }

        public static Square operator+(Square s1, Square s2)
        {
            Square res = new Square
            {
                A = s1.A + s2.A
            };
            return res;
        }
        public static Square operator -(Square s1, Square s2)
        {
            Square res = new Square
            {
                A = s1.A - s2.A
            };
            return res;
        }
        public static Square operator *(Square s1, Square s2)
        {
            Square res = new Square
            {
                A = s1.A * s2.A
            };
            return res;
        }
        public static Square operator /(Square s1, Square s2)
        {
            Square res = new Square
            {
                A = s1.A / s2.A
            };
            return res;
        }

        public static bool operator ==(Square s1, Square s2)
        {
            return s1.A == s2.A;
        }
        public static bool operator !=(Square s1, Square s2)
        {
            return !(s1 == s2);
        }
        public static bool operator >(Square s1, Square s2)
        {
            return s1.A > s2.A;
        }
        public static bool operator <(Square s1, Square s2)
        {
            return s1.A < s2.A;
        }
        public static bool operator >=(Square s1, Square s2)
        {
            return s1.A >= s2.A;
        }
        public static bool operator <=(Square s1, Square s2)
        {
            return s1.A <= s2.A;
        }
        public static bool operator true(Square s)
        {
            return s.A != 0;
        }
        public static bool operator false(Square s)
        {
            return s.A == 0;
        }
        public static implicit operator int(Square s)
        {
            return s.A;
        }
        public static explicit operator Rectangle(Square s)
        {
            return new Rectangle(s.A,s.A+10);
        }

    }
    class Rectangle
    {
        public int A { get; set; }
        public int B { get; set; }
        public Rectangle() : this(0, 0) { }
        public Rectangle(int a, int b) { A = a; B = b; }

        public override string ToString()
        {
            return $"A : {A}. B : {B}";
        }
        public static Rectangle operator ++(Rectangle r)
        {
            r.A++;
            r.B++;
            return r;
        }
        public static Rectangle operator --(Rectangle r)
        {
            r.A--;
            r.B--;
            return r;
        }

        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                A = r1.A + r2.A,
                B = r1.B - r2.B
            };
            return res;
        }
        public static Rectangle operator -(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                A = r1.A - r2.A,
                B = r1.B - r2.B
            };
            return res;
        }

        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                A = r1.A * r2.A,
                B = r1.B * r2.B
            };
            return res;
        }
        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                A = r1.A / r2.A,
                B = r1.B / r2.B
            };
            return res;
        }

        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            return r1.A==r2.A && r1.B==r2.B;
        }
        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return!(r1 == r2);
        }
        public static bool operator >(Rectangle r1, Rectangle r2)
        {
            return r1.A + r1.B > r2.A + r2.B;
        }

        public static bool operator <(Rectangle r1, Rectangle r2)
        {
            return r1.A + r1.B < r2.A + r2.B;
        }
        public static bool operator >=(Rectangle r1, Rectangle r2)
        {
            return r1.A + r1.B >= r2.A + r2.B;
        }
        public static bool operator <=(Rectangle r1, Rectangle r2)
        {
            return r1.A + r1.B <= r2.A + r2.B;
        }
        public static bool operator true(Rectangle r)
        {
            return r.A != 0 || r.B != 0;
        }
        public static bool operator false(Rectangle r)
        {
            return r.A == 0 && r.B == 0;
        }
        public static explicit operator int(Rectangle r)
        {
            return r.A + r.B;
        }
        public static implicit operator Square(Rectangle r)
        {
            return new Square(r.A + r.B);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(9);

            Rectangle rectangle = new Rectangle(4,6);


            Console.WriteLine($"Square : {square}");
            Console.WriteLine($"Square : {++square}");
            Console.WriteLine($"Square : {square++}");
            Console.WriteLine($"Square : {--square}");
            Console.WriteLine($"Square : {square--}");

        }
    }
}

using System;

namespace lab2
{
    public class A
    {
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        private int a;
        private int b;

        public int C { get { return (a + b); } }
    }

    class B : A
    {
        public B(int a, int b) : base(a, b) { }
        public B(int a, int b, int d) : base(a, b)
        {
            this.d = d;
        }
        private int d = -15;
        public int C2 { get { if (d < 0) { d *= -1; }  return C + d;  } }

    }

    class Program
    {
        static void Main(string[] args)
        {
            A objectA = new(10, 5);
            Console.WriteLine($"Result: {objectA.C}");
            B objectB = new(20, 20);
            Console.WriteLine($"Result: {objectB.C2}");
            B objectB2 = new(30, 30, 30);
            Console.WriteLine($"Result: {objectB2.C2}");

        }
    }
}

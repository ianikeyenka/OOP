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
        private int d;
        public int[] arr;
        public B(int a, int b, int d) : base(a, b)
        {
            this.d = d;

            this.arr = new int[a];
            for (int i = 0; i < this.arr.Length; i++)
            {
                this.arr[i] = C2 * i;
            }
        }

        public int C2 { get { if (d < 0) { d *= -1; } return C + d; } }

    }

    class Program
    {
        static void Main(string[] args)
        {           
            B objectB2 = new(4, 5, 6);
            Console.WriteLine($"Result {objectB2.C2}");

            foreach (int element in objectB2.arr)
                Console.WriteLine($"{element}");
        }
    }
}
using System;

namespace lab5
{
    public class A
    {
        private int x;
        public A(int x) { this.x = x; }
        public static bool operator true(A obj) => obj.x > 0;
        public static bool operator false(A obj) => obj.x <= 0;
        public static bool operator !(A obj)
        {
            if(obj)
                return false;
            else
                return true;
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            A objectA = new(5);
            A objectB = new(0);
            if (objectA) Console.WriteLine("True");
            else Console.WriteLine("False");

            if (!objectA) Console.WriteLine("True");
            else Console.WriteLine("False");

            if (objectB) Console.WriteLine("True");
            else Console.WriteLine("False");

            if (!objectB) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
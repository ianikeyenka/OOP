using System;

namespace lab1
{
    class A1
    {
        private int a = 12;
        private int b = 5;
        private int c;
        public int C
        {
            get
            {
                return a %= b;
            }

        }

    }

    class A2
    {
        private int a = 13;
        private int b = 15;
        public int C
        {
            get
            {
                return a + b;
            }

        }
    }
    class Programm
    {
        static void Main()
        {
            A1 f = new A1();
            int c1 = f.C;
            Console.WriteLine($"При %= с равняется: {c1}");

            A2 f1 = new A2();
            int c2 = f1.C;
            Console.WriteLine($"При + с равняется: {c2}");

            Console.ReadKey();

        }
    }
}

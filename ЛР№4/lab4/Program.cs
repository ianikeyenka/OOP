using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
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
        private int[] arr;
        private int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 } };

        //индексатор
        public Int32 this [Int32 index]{get { return arr[index]; } }
        public int this[int index1, int index2] { get { return arr1[index1, index2]; } }
        //размер arr
        public int Size { get { return arr.Length; } }
        public int Size1 { get { return arr1.Length; } }
        //Заполнение массива arr
        public B(int a, int b, int d) : base(a, b)
        {
            this.d = d;

            this.arr = new int[a];
            for (int i = 0; i < this.arr.Length; i++)
            {
                this.arr[i] = C2 * i;
            }
        }
        //нужная вещь
        public int C2 { get { return C + d; } }

    }

    public class C<T>
    {
        private T[] array = new T[3];
        public T this[int index] { get { return array[index]; } set { array[index] = value; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B objectB2 = new(4, 5, 6);
            //вывод массива
            for(int i = 0; i < objectB2.Size;i++)
                Console.Write($"{objectB2[i]}\t");
            Console.WriteLine("\n");

            for (int i = 0; i < 2; i++)
                for(int j = 0; j < 2; j++)
                Console.Write($"{objectB2[i,j]}\t");
            //Работа с параметризованным классом
            C<int> paramet = new C<int>();
            C<string> paramet2 = new C<string>();
            
            for (int i = 0; i < 3; i++)
            {
                paramet[i] = i;
            }
            for (int j = 0; j < 3; j++)
            {
                paramet2[j] = Convert.ToString(j);
            }
            Console.WriteLine("\n-----------------------------\n");
            Console.WriteLine("Parameterization!\nInteger");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{paramet[i]}\t");
            }
            Console.WriteLine("\nString");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{paramet2[i]}\t");
            }
        }
    }
}
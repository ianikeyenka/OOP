using System;
using System.Collections;

namespace lab6_1
{
    public class Human : IComparable<Human>
    {
        private string surname;
        private int birthday;
        private string status;

        public Human(string surname, int birthday, string status)
        {
            this.surname = surname;
            this.birthday = birthday;
            this.status = status;
        }

        public Human() { }

        public string Surnam { get { return surname; } set { surname = value; } }
        public int Birthday { get { return birthday; } set { birthday = value; } }
        public string Status { get { return status; } set { status = value; } }

        public virtual int Info()
        {
            DateTime age = DateTime.Now;
            return Convert.ToInt32(age.Year) - birthday;
        }

        public void Show()
        {
            Console.WriteLine($"\nThe person {surname}");
            Console.WriteLine($"{Info()} years old");
            Console.WriteLine($"Has a status {status}!");
        }

        public int CompareTo(Human p)
        {
            return this.birthday.CompareTo(p.birthday);
        }

    }
    public class Student : Human
    {
        private int mathGrade;
        private int physGrade;
        private int histGrade;

        public Student(string surname, int birthday, string status, int MathGrade, int PhysGrade, int HistGrade) : base(surname, birthday, status)
        {
            this.mathGrade = mathGrade;
            this.physGrade = physGrade;
            this.histGrade = histGrade;
        }
        public int MathGrade { get { return mathGrade; } set { mathGrade = value; } }
        public int PhysGrade { get { return physGrade; } set { physGrade = value; } }
        public int HistGrade { get { return histGrade; } set { histGrade = value; } }

        public float avgGrade()
        {
            return (mathGrade + PhysGrade + HistGrade) / 3;
        }

        public override int Info()
        {
            int maxGrade = physGrade;
            if (maxGrade < mathGrade) maxGrade = mathGrade;
            if (maxGrade < histGrade) maxGrade = histGrade;
            return maxGrade;
        }

    }

    interface IComparer<p>
    {
        int Compare(p o1, p o2);
    }

    class HumanComparer : IComparer<Human>
    {
        public int Compare(Human h1, Human h2)
        {
            if (String.Compare(h1.Surnam, h2.Surnam) > 0)
                return 1;
            else if (String.Compare(h1.Surnam, h2.Surnam) < 0)
                return -1;
            else
                return 0;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Castro", 2002, "Student");
            Human human2 = new Human("Parker", 2001, "Student");
            Human human3 = new Human("Miller", 1986, "Teacher");
            Human[] array = new Human[] { human1, human2, human3 };

            Console.WriteLine("Sorting by date of birth!\n");
            Array.Sort(array);
            foreach (Human n in array)
            {
                Console.WriteLine($"{n.Surnam} - {n.Birthday} - {n.Status}");
            }

            Console.WriteLine("\nSorting by surname!\n");
            HumanComparer humanComparer = new HumanComparer();
            Array.Sort(array, humanComparer.Compare);

            foreach (Human p in array)
            {
                Console.WriteLine($"{p.Surnam} - {p.Birthday} - {p.Status}");
            }

            foreach (Human n in array)
            {
                n.Show();
            }

            Console.ReadLine();

        }
    }
}
using System;

namespace class_uravnenie
{
    class Uravnenie
    {
        public double a;
        public double b;

        public double Reshenie(double a, double b)
        {
            return b / a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uravnenie mU = new Uravnenie();
            Console.WriteLine("Введем данные уравния типа a*x=b");
            Console.WriteLine("a = ");
            mU.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b = ");
            mU.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("X = " + mU.Reshenie(mU.a, mU.b));
        }
    }
}

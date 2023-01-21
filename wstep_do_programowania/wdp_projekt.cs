using System;
using System.Collections.Generic;

namespace wstep_do_programowania
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcVer1 calcOne = new();
            calcOne.PrintEverything();

            CalcVer2 calcTwo = new();
            calcTwo.PrintEverything();

            List<CalcVer1> calcsV1 = new List<CalcVer1>();
            calcsV1.Add(new CalcVer1(100, 20));
            calcsV1.Add(new CalcVer1(234, 17));
            calcsV1.Add(new CalcVer1(5491, 0));

            foreach (CalcVer1 c in calcsV1)
            {
                c.PrintEverything();
            }

            List<CalcVer2> calcsV2 = new List<CalcVer2>();
            calcsV2.Add(new CalcVer2(100, 20));
            calcsV2.Add(new CalcVer2(234, 17));
            calcsV2.Add(new CalcVer2(5491, 0));

            foreach (CalcVer2 c in calcsV2)
            {
                c.PrintEverything();
            }
        }
    }

    interface ICalculator
    {
        int Sum(int a, int b);
        int Subtraction(int a, int b);
        int Multiplication(int a, int b);
        int Division(int a, int b);
    }

    class CalcVer1 : ICalculator
    {
        int num1;
        int num2;

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }

        public CalcVer1()
        {
            Num1 = 15;
            Num2 = 5;
        }

        public CalcVer1(int a, int b)
        {
            Num1 = a;
            Num2 = b;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            int result;
            try
            {
                result = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                result = 0;
            }
            
            return result;
        }

        public void PrintEverything()
        {
            Console.WriteLine("{0} + {1} = {2}", Num1, Num2, Sum(Num1, Num2));
            Console.WriteLine("{0} - {1} = {2}", Num1, Num2, Subtraction(Num1, Num2));
            Console.WriteLine("{0} * {1} = {2}", Num1, Num2, Multiplication(Num1, Num2));
            Console.WriteLine("{0} / {1} = {2}", Num1, Num2, Division(Num1, Num2));

            Console.WriteLine();
        }
    }

    class CalcVer2 : CalcVer1
    {
        public CalcVer2() { }

        public CalcVer2(int a, int b) : base(a, b) { }


        public double Power(int a, int b)
        {
            return Math.Pow(a, b);
        }

        public new void PrintEverything()
        {
            Console.WriteLine("{0} + {1} = {2}", Num1, Num2, Sum(Num1, Num2));
            Console.WriteLine("{0} - {1} = {2}", Num1, Num2, Subtraction(Num1, Num2));
            Console.WriteLine("{0} * {1} = {2}", Num1, Num2, Multiplication(Num1, Num2));
            Console.WriteLine("{0} / {1} = {2}", Num1, Num2, Division(Num1, Num2));
            Console.WriteLine("{0} ** {1} = {2}", Num1, Num2, Power(Num1, Num2));

            Console.WriteLine();
        }
    }
}
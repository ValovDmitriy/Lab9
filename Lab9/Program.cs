using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int oper = 0;
            Console.WriteLine("Привет Кальк");
            Console.Write("Введите целое число. X=");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректно введен X");
                return;
            }
            Console.Write("Введите целое число. Y=");
            try
            {
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректно введен Y");
                return;
            }
            Console.WriteLine("Введите код операции:\n\t1-сложение\n\t2-вычитание\n\t3-произведение\n\t4-частное");
            try
            {
                Console.Write("Вы ввели:");
                oper = Convert.ToInt32(Console.ReadLine());
                if (oper < 1 || oper > 4)
                {
                    throw new Exception("Некорректно введен код операции");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректно введен код операции");
                return;
            }
            switch (oper)
            {
                case 1:
                    Console.Write("{0}+{1}=", x, y);
                    Add(x, y);
                    break;
                case 2:
                    Console.Write("{0}-{1}=", x, y);
                    Subt(x, y);
                    break;
                case 3:
                    Console.Write("{0}*{1}=", x, y);
                    Mult(x, y);
                    break;
                case 4:
                    Divi(x, y);
                    break;
            }
        }
        static void Add(int a, int b)
        {
            int add = a + b;
            Console.Write(add);
        }
        static void Subt(int a, int b)
        {
            int subt = a - b;
            Console.Write(subt);
        }
        static void Mult(int a, int b)
        {
            int mult = a * b;
            Console.Write(mult);
        }
        static void Divi(int a, int b)
        {
            int divi = 0;
            try
            {
                divi = a / b;
                Console.Write("{0}/{1}=", a, b);
                Console.Write(divi);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль");
            }
        }
    }
}

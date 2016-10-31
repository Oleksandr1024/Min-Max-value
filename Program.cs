using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string n1 = Console.ReadLine();

            Console.WriteLine("Введите второе число");
            string n2 = Console.ReadLine();

            Console.WriteLine("Введите третье число");
            string n3 = Console.ReadLine();

            Console.WriteLine("Введите четвёртое число");
            string n4 = Console.ReadLine();

            Console.WriteLine("Введите пятое число");
            string n5 = Console.ReadLine();

            int number1 = int.Parse(n1);
            int number2 = int.Parse(n2);
            int number3 = int.Parse(n3);
            int number4 = int.Parse(n4);
            int number5 = int.Parse(n5);

            Console.WriteLine("Наибольшее число с помощью метода Max1  "+ Max1(number1, number2, number3, number4, number5));

            Console.WriteLine("Наибольшее число с помощью метода Max2  " + Max2(number1, number2, number3, number4, number5));

            Console.WriteLine("Наименьшее число  " + Min(number1, number2, number3, number4, number5));

            Console.ReadKey();
        }


       public static int Min(int number1, int number2, int number3, int number4, int number5)
        {
            int min = number1;
            if (min > number2) min = number2;
            if (min > number3) min = number3;
            if (min > number4) min = number4;
            if (min > number5) min = number5;
            return min;
        }
        
        public static int Max2(int number1, int number2, int number3, int number4, int number5)
        {
            int max = number1;
            if (max < number2) max = number2;
            if (max < number3) max = number3;
            if (max < number4) max = number4;
            if (max < number5) max = number5;
            return max;
            
        }

        public static int Max1(int number1, int number2, int number3, int number4, int number5)
        {
            int max;
            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    if (number1 > number4)
                    {
                        if (number1 > number5)
                        {
                            max = number1;
                        }
                        else
                        {
                            max = number5;
                        }
                    }
                    else
                    {
                        if (number4 > number5)
                        {
                            max = number4;
                        }
                        else
                        {
                            max = number5;
                        }
                    }
                }
                else
                {
                    if (number3 > number4)
                    {
                        if (number3 > number5)
                        {
                            max = number3;
                        }
                        else
                        {
                            max = number5;
                        }
                    }
                    else
                    {
                        if (number4 > number5)
                        {
                            max = number4;
                        }
                        else
                        {
                            max = number5;
                        }
                    }
                }
            }
            else
            {
                if (number2 > number3)
                {
                    if (number2 > number4)
                    {
                        if (number2 > number5)
                        {
                            max = number2;
                        }
                        else
                        {
                            max = number5;
                        }
                    }
                    else
                    {
                        if (number4 > number5)
                        {
                            max = number4;
                        }
                        else
                        {
                            max = number5;
                        }
                    }
                }
                else
                {
                    if (number3 > number4)
                    {
                        if (number3 > number5)
                        {
                            max = number3;
                        }
                        else
                        {
                            max = number5;
                        }
                    }
                    else
                    {
                        if (number4 > number5)
                        {
                            max = number4;
                        }
                        else
                        {
                            max = number5;
                        }
                    }
                }
            }
            return max;
        }
    }
}

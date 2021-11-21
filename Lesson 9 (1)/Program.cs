using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            int operand = 0;
            double resultat = 0;
            try
            {
                Console.Write("Введите первое число ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе число ");
                b = Convert.ToDouble(Console.ReadLine());
                try
                {
                    Console.WriteLine("Введите код операции:\n \t 1-сложение \n \t 2-вычитание \n \t 3-произведение\n \t 4-частное");
                    operand = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ваш выбор: {0}", operand);
                    if (operand > 0 && operand < 5)
                    {
                        try
                        {
                            switch (operand)
                            {
                                case 1:
                                    {
                                        resultat = a + b;
                                        break;
                                    }
                                case 2:
                                    {
                                        resultat = a - b;
                                        break;
                                    }
                                case 3:
                                    {
                                        resultat = a * b;
                                        break;
                                    }
                                case 4:
                                    {
                                        resultat = a / b;
                                        break;
                                    }
                            }
                        }
                        catch (DivideByZeroException)
                        {
                            //Console.WriteLine("Деление на 0!");
                            throw;
                        }
                        Console.WriteLine("Результат = {0}", resultat);
                    }
                    else
                    {
                        Console.WriteLine("Нет операции с указанным номером");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }





    }
}

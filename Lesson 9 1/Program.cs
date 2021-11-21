using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int resultat = 0;
            int operand = 0;

            Console.Write("Введите первое число ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите код операции:\n \t 1-сложение \n \t 2-вычитание \n \t 3-произведение\n \t 4-частное");
            operand = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш выбор: {0}", operand);

            if (operand > 0 && operand < 5)
            {
                
                    switch (operand)
                    {
                        case 1:
                            {
                                resultat = a + b;
                                Console.WriteLine("Результат = {0}", resultat);
                                break;
                            }
                        case 2:
                            {
                                resultat = a - b;
                                Console.WriteLine("Результат = {0}", resultat);
                                break;
                            }
                        case 3:
                            {
                                resultat = a * b;
                                Console.WriteLine("Результат = {0}", resultat);
                                break;
                            }
                        case 4:
                            {
                                resultat = a / b;
                            try
                            {
                                Console.WriteLine("Деление = {0}", resultat);
                            }
                            catch (DivideByZeroException)
                            {

                                Console.WriteLine("Деление на 0!!!!!!");
                            }
                                
                                break;
                            }

                    }
               
            }
            else
            {
                Console.WriteLine("Нет операции с указанным номером");
            }


            
            Console.ReadKey();
        }

    }
}

//************************************************************
//*Практическая работа №8                                    *
//* выполнил:Кондаков.П.А;Группа 2ИСП                        *
//*освоить конструкции циклов с условиями while и do − while.*
//************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PR_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Практическая работа №8. \nЗдравствуйте!");
            int N, X;//N-Натуральное число,Y-Выражение
            int v1, v2, v3, v4;

            try
            {

                Console.Write("\nВведите значение натурального четырехзначного числа N.\n");
                Console.Write("\tN= ");
                N = Int32.Parse(Console.ReadLine());

                byte count_zero = 0;

                v1 = N / 1000;
                v4 = N % 10;
                v2 = N / 100 % 10;
                v3 = N / 10 % 10;
                while (true)
                {
                    if (N >= 10000) throw new ArgumentException("Это не четырехзначное число!");

                    else
                    {
                        if (v1 == 0)
                            count_zero++;
                        if (v2 == 0)
                            count_zero++;
                        if (v3 == 0)
                            count_zero++;
                        if (v4 == 0)
                            count_zero++;
                    }
                    break;
                };
                if (count_zero % 2 == 0) //Проверка на четность
                {
                    Console.WriteLine("Количество нулей четно!");
                    X = (int)(Math.Pow(N, 3) + (1 / Math.Sqrt((2 * N) + 10)));
                }
                else
                {
                    Console.WriteLine("Количество нулей нечетно!");
                    X = (int)(Math.Pow(N, -2) + (1 / Math.Sqrt((2 * N) + 10)));
                }
                Console.WriteLine($"ответ:[{X}]");
            }
            catch (ArgumentException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка:" + fe.Message);
            }
            catch (Exception e) //
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("что-то пошло не так.Ошибка:" + e.Message);
            }
            Console.ReadKey();
        }
    }
}
















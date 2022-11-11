//************************************************************
//*Практическая работа №8                                    *
//* выполнил:Кондаков.П.А;Группа 2ИСП                        *
//*освоить конструкции циклов с условиями while и do − while.*
//************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №8. \nЗдравствуйте!");
            int N,Y;//N-Натуральное число,Y-Выражение
          int v1, v2, v3, v4, v5;
            try
            {
                Console.Write("\nВведите значение натурального пятизначного числа N.\n");
                Console.Write("\tN= ");
                N = Int32.Parse(Console.ReadLine());
                int N1 = N;
                byte count_zero;
                count_zero = (byte)N;


                while (N>99999)
                {
                    if (N >= 10000 && N<=99999)
                    {
                        if (v1 ==0) 
                        count_zero++;

                        if (count_zero %2==0) //Проверка на четность
                        Y = (int)(Math.Pow(N, 3) + (1 / Math.Sqrt((2 * N) + 10)));
                        
                        else
                            Y = (int)(Math.Pow(N, -2) + (1 / Math.Sqrt((2 * N) + 10)));
                    }
                    else Console.WriteLine("Это не пятизначное число");
                }
            }
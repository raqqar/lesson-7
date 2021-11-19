using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_7
{
    class Program
    {
        //Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше
        //(создать метод для вычисления  площади  треугольника по длинам его сторон).
        //Для решения задачи можно использовать формулу Герона
        static void Main(string[] args)
        {
            double S1 = 0;
            double S2 = 0;
            //Задаем длины треугольников
            for (int i = 0; i < 2; i++)
            {
                if (i==0)
                {
                    Console.WriteLine("Введите длины сторон первого треугольника");
                }
                else
                {
                    Console.WriteLine("Введите длины сторон второго треугольника");
                }
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                double S = tGerona(a, b, c);
                //Вычисляем площадь какого треугольника больше
                Console.WriteLine("Площадь треугольника = {0:N2}", S);
                if (i == 0)
                {
                    S1 = S;
                }
                else if (i > 0)
                {
                    S2 = S;
                }
            }
            //Выводим в сообщение площадь какого треугольника больше
            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else if (S2>S1)
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else if (S1==S2&& S1!=0)
            {
                Console.WriteLine("Площади треугольников равны");
            }

            Console.ReadKey();
        }
        static double tGerona(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }

}


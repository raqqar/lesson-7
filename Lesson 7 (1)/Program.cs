using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7__1_
{
    class Program
    {
        //Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше
        //(создать метод для вычисления  площади  треугольника по длинам его сторон).
        //Для решения задачи можно использовать формулу Герона
        static void Main(string[] args)
        {
            //Задаем длины треугольников
            Console.WriteLine("Введите длины сторон первого треугольника");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            double z1 = Convert.ToInt32(Console.ReadLine());
            double S1 = tGerona(x1, y1, z1);

            Console.WriteLine("Введите длины сторон второго треугольника");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            double z2 = Convert.ToInt32(Console.ReadLine());
            double S2 = tGerona(x2, y2, z2);

            if (S1>S2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else if ((S1 > S2))
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else if (S1==S2&&S1!=0)
            {
                Console.WriteLine("Площади треугольников равны");
            }

            Console.ReadKey();
        }
        static double tGerona(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
    }

}
   

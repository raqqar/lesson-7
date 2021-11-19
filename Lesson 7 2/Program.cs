using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_2
{
    class Program
    {
        //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.

        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба ");
            double a = Convert.ToDouble(Console.ReadLine());
            ValSqCube(a);
            Console.ReadKey();
        }
        static void ValSqCube(double a)
        {
            double Val = Math.Pow(a, 3);
            double Sq = (6 * Math.Pow(a, 2));
            Console.WriteLine("При длинне ребра = {0} \nОбъем = {1:N2} \nПлощадь поверхности = {2:N2} ", a,Val,Sq);
        }
    }
}

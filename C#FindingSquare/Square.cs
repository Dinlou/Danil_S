using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFigure
{
    //Целью библиотеки является универсальное опознание фигуры и нахождение ее площади 
    //(программа ограничена нахождением площади круга по радиусу и типа с площадью треугольника) 
   public class Square
    {
        public static void calc()
        {
            string trans;
            int j = 0;
            double[] mas = new double[4];
            double[] lst = new double[4];
            for (int i = 0; i < 4; i++)
            {
                trans = Console.ReadLine();
                try
                {
                    mas[i] = Convert.ToInt32(trans); // Чтобы не было ошибки предотвращаем ввод неверного типа данных
                }
                catch
                {
                    mas[i] = 0;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (mas[i] != 0)
                {
                    lst[j] = Math.Abs(mas[i]); //Если пользователь введет правильные данные и данные не того типа то они перемешаются
                    j++;             //и будет трудно выцепить данные для вычисления, чтобы это исключить заполняем второй массив 
                }
            }
            switch (j)
            {
                case 0:
                    Console.WriteLine("Вы не ввели значений");
                    break;
                case 1:
                    Console.WriteLine("Вы ввели периметр круга \n Площадь круга S= " + Convert.ToDouble(3.14 * (lst[0] * lst[0])));
                    break;
                case 2:
                    Console.WriteLine("Вы ввели 2 стороны, такой фигуры нет");
                    break;
                case 3:
                    {
                        Console.WriteLine("Вы ввели треугольник");
                        triangle(lst[0], lst[1], lst[2]);
                    }
                    break;
                case 4:
                    Console.WriteLine("Вы ввели четвырехугольник");
                    break;
            }

        }
        // Регион для методов, чтобы они не мешались если будут добавлены новые
        #region methods
        public static void triangle(double a, double b, double c) //Метод для нахождения типа и площади треугольника
        {
            double bedro = 1, osnova = 1;
            if (a == b & a == c)
                Console.WriteLine("Треугольник является равносторонним \n Площадь треугольника S= " + Convert.ToDouble((Math.Sqrt(3) / 4)) * (a * a));
            if (a == b & a != c | a == c & a != b | b == c & b != a)
            {
                if (a == b & a != c)
                {
                    bedro = a;
                    osnova = c;
                }
                else
                    if (b == c & b != a)
                {
                    bedro = b;
                    osnova = a;
                }
                else
                    if (a == c & a != b)
                {
                    bedro = c;
                    osnova = b;
                }
                Console.WriteLine("Треугольник является равнобедренным \n Площадь треугольника S= " + ((osnova / 4.0) * Math.Sqrt(Math.Abs(4.0 * (bedro * bedro) - (osnova * osnova)))));
            }
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                if (a * a + b * b == c * c)
                {
                    Console.WriteLine("Треугольник является прямоугольным \n Площадь треугольника S= " + ((a * b) / 2.0));
                }
                if (a * a + c * c == b * b)
                {
                    Console.WriteLine("Треугольник является прямоугольным \n Площадь треугольника S= " + ((a * c) / 2.0));
                }
                if (c * c + b * b == a * a)
                {
                    Console.WriteLine("Треугольник является прямоугольным \n Площадь треугольника S= " + ((c * b) / 2.0));
                }
            }

        }
        #endregion 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.Write("Введите целое число. X=");
            dynamic X=0;
            try
            {
                X = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибка! {0}", ex.Message);
            }
            Console.Write("Введите целое число. Y=");
            dynamic Y = 0;
            try
            {
                Y = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибка! {0}", ex.Message);
            }
            Console.WriteLine("Введите код операции:");
            Console.WriteLine("     1 - сложение");
            Console.WriteLine("     2  -вычитание");
            Console.WriteLine("     3 - произведение");
            Console.WriteLine("     4 - частное");
            Console.Write("Ваш выбор:");
            dynamic Z = 0;
            try
            {
                Z = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибка! {0}", ex.Message);
            }
            int S = 0;
            if (Z == 1)
            {
                S = X + Y;
                Console.WriteLine(S);
            }
            if (Z == 2)
            {
                S = X - Y;
                Console.WriteLine(S);
            }
            if (Z == 3)
            {
                S = X * Y;
                Console.WriteLine(S);
            }
            if (Z == 4)
            {
                try
                {
                    S = X / Y;
                    Console.WriteLine(S);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ошибка! {0}", ex.Message);
                }
            }
            if (Z > 4)
            {
                Console.WriteLine("Нет операции с указанным номером");
            }
            Console.ReadKey();
        }
    }
}

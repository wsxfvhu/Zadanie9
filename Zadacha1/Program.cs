using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вас приветствует калькулятор!");
            Console.Write("Введите целое число X=");
            try
            {
                long x = Convert.ToInt64(Console.ReadLine());
                Console.Write("Введите целое число Y=");
                long y = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("          1-сложение");
                Console.WriteLine("          2-вычетание");
                Console.WriteLine("          3-произведение");
                Console.WriteLine("          4-часное");
                byte cod = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Ваш выбор: {0}", cod);
                if (cod == 1)
                {
                    Console.WriteLine(x + y);
                }
                if (cod == 2)
                {
                    Console.WriteLine(x - y);
                }
                if (cod == 3)
                {
                    Console.WriteLine(x * y);
                }
                if (cod == 4)
                {
                    Console.WriteLine((decimal)x / y);
                }
                if (cod > 4 || cod < 1)
                {
                    Console.WriteLine("Нет операции с указанным номером");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка,не верный формат ");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Ошибка,не правильное число ");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка,деление на ноль ");
            }
            Console.ReadKey();
        }
    }
}

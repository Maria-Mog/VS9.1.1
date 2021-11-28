using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS9._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Вас приветствует калькулятор!\nВведите целое число Х= ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число Y= ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите код операции:\n     1- сложение\n     2- вычитание\n     3- произведение\n     4- часное\nВаш выбор:");
                int z = Convert.ToInt32(Console.ReadLine());
                if (z <= 0 || z > 4)
                {
                    throw new ArgumentException("Нет операции с указанным номером");
                }

                double rezult = 0;
                if (z == 1)
                {
                    rezult = x + y;
                }
                if (z == 2)
                {
                    rezult = x - y;

                }
                if (z == 3)
                {
                    rezult = x * y;
                }
                if (z == 4)
                {
                    rezult = ((double)x) / y;
                }

                Console.Write("Результат = {0}", rezult);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}

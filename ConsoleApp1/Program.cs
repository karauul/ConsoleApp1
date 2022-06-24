using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int res = 0;
            Console.WriteLine("Нажмите enter для начала работы с программой");
            int number=0;
            Console.ReadLine();
            while (number < 3)
            {


                Console.WriteLine("Выберите способ вычисления:Sum ili vich");
                 int answer = Convert.ToInt32(Console.ReadLine());

                {
                    switch (answer)
                    {
                        case 1:

                            Console.WriteLine("Введите первое число");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число");
                            b = Convert.ToInt32(Console.ReadLine());
                            res = a + b;
                            Console.WriteLine("Ответ: " + res);
                            break;
                        case 2:
                            Console.WriteLine("Введите первое число");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число");
                            b = Convert.ToInt32(Console.ReadLine());
                            res = a - b;
                            Console.WriteLine("Ответ: " + res);
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("Неверно введенное значение");
                            Console.ReadLine();
                            break;
                    }

                    number = answer;






                }
            }
        }
    }
}

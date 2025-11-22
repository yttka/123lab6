using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определить првильность даты, введеные с клавиатуры");



            
            {

                //день
                Console.Write(" Введите день (1-31): ");

                int day = int.Parse(Console.ReadLine());


                //месяц
                Console.Write(" Введите месяц (1-12): ");

                int mounth = int.Parse(Console.ReadLine());
                {
                    if (day >= 1 && day <= 31)
                    {
                        Console.WriteLine("Введен корректный день: " + day);
                    }

                    else
                    {
                        Console.WriteLine("Введен не корректный день: " + day);
                    }
                }
                {
                    if (mounth >= 1 && mounth <= 12)
                    {
                        Console.WriteLine("Введен корректный месяц: " + mounth);
                    }
                    else
                    {
                        Console.WriteLine("Введен не корректный месяц: " + mounth);
                    }
                }

                Console.ReadLine();



            }

        }
    }
}

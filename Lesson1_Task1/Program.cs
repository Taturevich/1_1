using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявление объектов класса
            TravelExpenses[] mission = new TravelExpenses[5];
            mission[0] = new TravelExpenses("Ivar Maksutov", 40000, 18);
            mission[1] = new TravelExpenses("Maxim Valov", 38000, 16);
            mission[2] = null;
            mission[3] = new TravelExpenses("Zahar Baturin", 51000, 25);
            mission[4] = new TravelExpenses();

            //Вывод информации об объектах методом Show()
            for (int i = 0; i < mission.Length; i++)
            {
                if (mission[i] != null)
                {
                    Console.WriteLine("Информация о командирвке №" + (i + 1));
                    mission[i].Show();
                    Console.WriteLine();
                }
                
            }

            //Изменение транспортных расходов в последнем элементе массива
            mission[4].Fare=100000;

            //Вывод суммарного количества дней первых двух командировок
            Console.WriteLine("Общая продолжительность первых двух командировок: "+(mission[0].Days+mission[1].Days)+" дня(ей)\n");

            //Вывод массива на консоль с использованием метода ToString()
            Console.WriteLine("Информация в csv формате:\n");
            for (int i = 0; i < mission.Length; i++)
            {
                if (mission[i] != null)
                {
                    Console.WriteLine(mission[i]);
                }
            }
            Console.ReadKey();
        }
    }
}

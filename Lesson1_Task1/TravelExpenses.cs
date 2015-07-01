using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task1
{
    class TravelExpenses
    {
        public const int per_diem = 85000; // суточные в бел.руб
        string initials; // фамилия и имя работника
        int fare; // транспортные расходы в бел.руб
        int days; // количество дней

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public TravelExpenses()
        {

        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="initials"></param>
        /// <param name="fare"></param>
        /// <param name="days"></param>
        public TravelExpenses(string initials, int fare, int days)
        {
            this.initials =initials;
            this.fare = fare;
            this.days = days;
        }



        public string Initials
        {
            get { return initials; }
            set { this.initials = value; }
        }

        public int Fare
        {
            get { return fare; }
            set { this.fare = value; }
        }

        public int Days
        {
            get { return days; }
            set { this.days = value; }
        }

        /// <summary>
        /// Расчёт общей величины расходов
        /// </summary>
        /// <returns></returns>
        public int GetTotal()
        {
            int total;
            total = fare + days * per_diem;
            return total;
        }

        /// <summary>
        /// Вывод всех полей в консоли по одному
        /// </summary>
        public void Show()
        {
            Console.WriteLine("per_diem="+per_diem);
            Console.WriteLine("initials="+initials);
            Console.WriteLine("fare="+fare);
            Console.WriteLine("days="+days);
            Console.WriteLine("total="+GetTotal());
        }

        /// <summary>
        /// Вывод информации в csv формате
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return per_diem + ";" + initials + ";" + fare + ";" + days + ";" + GetTotal() + ";";
        }


    }
}

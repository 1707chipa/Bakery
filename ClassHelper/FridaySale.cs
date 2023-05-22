using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery_Sanin_Cheprasov.ClassHelper
{
    public class FridaySale
    {
        public string ApplyDiscount(string a)
        {
            // Получаем текущую дату
            DateTime currentDate = DateTime.Today;

            // Проверяем, является ли текущая дата пятой пятницей
            if (IsFifthFriday(currentDate))
            {
                // Применяем скидку 20% к общей стоимости
                double currentCost = Convert.ToDouble(a);
                double discountedCost = currentCost * 0.8;
                a = discountedCost.ToString();
                return a;
            }
            return a;
        }

        private bool IsFifthFriday(DateTime date)
        {
            // Проверяем, является ли текущая дата пятницей
            if (date.DayOfWeek != DayOfWeek.Friday)
            {
                return false;
            }

            // Получаем номер текущего дня в месяце
            int dayOfMonth = date.Day;

            // Получаем количество пятниц в текущем месяце
            int fridaysCount = Enumerable.Range(1, dayOfMonth).Count(d => new DateTime(date.Year, date.Month, d).DayOfWeek == DayOfWeek.Friday);

            // Проверяем, является ли текущая пятница пятой пятницей в текущем месяце
            if (fridaysCount == 5)
            {
                return true;
            }

            return false;
        }
    }
}

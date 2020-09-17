using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_1.Приветствие
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 year, age, month, day, dayToday, monthToday, yearToday;
            DateTime now = DateTime.Now;
            monthToday = now.Month; 
            dayToday = now.Day; 
            yearToday = now.Year;
            string name;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добрый день, как вас зовут?");
                name = Console.ReadLine();
                try
                {
                    Console.WriteLine("В каком году вы родились?");
                    year = ushort.Parse(Console.ReadLine());
                    if (year >= 2020)
                    {
                        Console.WriteLine("Вы ввели некоректный год рождения, попробуйте снова");
                        continue;
                    }

                    Console.WriteLine("Назовите месяц вашего рождения.");
                    month = byte.Parse(Console.ReadLine());
                    if (month > 13 || month < 1)
                    {
                        Console.WriteLine("такого месяца не существует, попробуйте снова");
                        continue;
                    }

                    Console.WriteLine("Назовите день вашего рождения.");
                    day = byte.Parse(Console.ReadLine());
                    if (day > 31 || day < 1)
                    {
                        Console.WriteLine("Вы ввели некоректную дату, попробуйте снова");
                        continue;
                    }
                    if (month == 2 && day > 29)
                    {

                        Console.WriteLine("Вы ввели некоректный день, попробуйте снова");
                        continue;
                    }

                    if (month == 2 && day == 29 && (year % 4 != 0 || (year % 100 == 0 && year % 400 != 0)))
                    {
                        Console.WriteLine("Этот год не високосный, 29ое ферваля не допустимая дата");
                        continue;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Вводить можно только цифры, попробуйте еще раз");
                    Console.ReadLine();
                    continue;
                }
               
                age = yearToday - year;
                if (monthToday < month || (month == monthToday && dayToday < day))
                {
                    age--;
                }

                Console.WriteLine("Привет, " + name + " Ваш возраст равен: " + age + " лет.");
                Console.ReadLine();
            }
        }
    }
}

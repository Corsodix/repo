using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateFunc();

            DateCalculation();
        }
        //F.Реализовать функции для вычисления даты используя встроенные структуры DateTime и TimeSpan.
        //    Функции: ввод даты, вычисление разницы между двумя датами, определение високосного года.
        public static void DateFunc()
        {
            string dateString;
            DateTime fDate = new DateTime();
            DateTime sDate = new DateTime();
            TimeSpan difDate = new TimeSpan();

            Console.Write("Введите первую дату в формате ДД.ММ.ГГГГ: ");
            dateString = Console.ReadLine();
            DateTime.TryParse(dateString, out fDate);
            Console.Write("Введите вторую дату в формате ДД.ММ.ГГГГ: ");
            dateString = Console.ReadLine();
            DateTime.TryParse(dateString, out sDate);

            Console.Write(fDate+" - ");
            if (DateTime.IsLeapYear(fDate.Year))
                Console.WriteLine("Високосный год");
            else
                Console.WriteLine("Не високосный год");

            Console.Write(sDate + " - ");
            if (DateTime.IsLeapYear(sDate.Year))
                Console.WriteLine("Високосный год");
            else
                Console.WriteLine("Не високосный год");

            difDate = fDate - sDate;
            Console.WriteLine("Разница между {0} и {1} равна {2} дней",fDate,sDate,difDate.Days);
            Console.ReadKey();
        }


        //C** Реализовать собственную структуру «Дата». 
        //Функции «Дата»: ввод даты, прибавление к дате определенного числа дней, вычисление разницы между двумя датами,
        //    определение високосного года, выводы даты с указанием месяца цифрой и словом

        public static void DateCalculation()
        {
            Console.Clear();
            DateStruct firstDate = new DateStruct();
            DateStruct secondDate = new DateStruct();
            int dayDif, monthDif, yearDif;
            firstDate = DateInput();
            secondDate = DateInput();
            firstDate.monthName = MonthName(firstDate.month);
            secondDate.monthName = MonthName(secondDate.month);
            dayDif = firstDate.day - secondDate.day;
            monthDif = firstDate.month - secondDate.month;
            yearDif = firstDate.year - secondDate.year;

            Console.WriteLine("Первая дата: \t\t{0} {1} {2} год", firstDate.day, firstDate.monthName, firstDate.year);
            Console.WriteLine("Вторая дата: \t\t{0} {1} {2} год", secondDate.day, secondDate.monthName, secondDate.year);
            Console.WriteLine("Отличия дат на: \t{0} дней, {1} месяц(ев), {2} лет", dayDif, monthDif, yearDif);
            Console.ReadKey();

        }
        public struct DateStruct
        {
            public int year, month, day;
            public string monthName;
        }
        public static DateStruct DateInput()
        {
            DateStruct outputDate = new DateStruct();
            string inputDate;
            string dayStr="", monthStr = "", yearStr = "";
            Console.Write("Введите первую дату в формате ДДММГГГГ: ");
            inputDate = Console.ReadLine();
            for (int i = 0; i < inputDate.Length; i += 2)
            {
                if (i < 1)
                {
                    dayStr = string.Join("", inputDate[i], inputDate[i + 1]);
                    int.TryParse(dayStr, out outputDate.day);
                    if (outputDate.day >= 31)
                    {
                        Console.WriteLine("Неправельный день");
                        //outputDate.day = 31;
                    }
                }
                else if (i < 3)
                {
                    monthStr = string.Join("", inputDate[i], inputDate[i + 1]);
                    int.TryParse(monthStr, out outputDate.month);
                    if (outputDate.month > 13)
                    {
                        Console.WriteLine("Неправельный месяц");
                        //outputDate.month = 12;
                    }
                }
                else if (i < 5)
                {
                    yearStr = string.Join("", inputDate[i], inputDate[i + 1], inputDate[i + 2], inputDate[i + 3]);
                    int.TryParse(yearStr, out outputDate.year);
                }
                //else Console.WriteLine("Неправильный формат даты");
            }


            return outputDate;
        }
        public static string MonthName(int _month)
        {
            string monName="";
            switch(_month)
            {
                case 1:
                    monName = "Январь";
                    break;
                case 2:
                    monName = "Февраль";
                    break;
                case 3:
                    monName = "Март";
                    break;
                case 4:
                    monName = "Апрель";
                    break;
                case 5:
                    monName = "Май";
                    break;
                case 6:
                    monName = "Июнь";
                    break;
                case 7:
                    monName = "Июль";
                    break;
                case 8:
                    monName = "Август";
                    break;
                case 9:
                    monName = "Сентярь";
                    break;
                case 10:
                    monName = "Октябрь";
                    break;
                case 11:
                    monName = "Ноябрь";
                    break;
                case 12:
                    monName = "Декабрь";
                    break;
            }
            return monName;
        }
    }
}

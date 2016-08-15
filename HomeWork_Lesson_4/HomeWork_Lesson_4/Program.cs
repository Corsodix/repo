using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson_4
{
    //2. Реализовать программу “Средний уровень заработной платы”. Вводятся зарплаты 7 сотрудников.
    //    Функция принимает List<int> данных и возвращает на выходе среднее значение заработной платы.

    class Program
    {
        static void Main(string[] args)
        {
            {
                Employee[] eArray = new Employee[3]
                {
            new Employee("Иван", "Иванов","Иванович","Бухгалтер",1500),
            new Employee("Петр", "Петров","Петрович","Директор",2000),
            new Employee("Василий", "Васильев","Васильевич","Охраник",1000),
                };

                EmployeeList eList = new EmployeeList(eArray);
                foreach (Employee p in eList)
                    Console.WriteLine(p.name + " " + p.surname);
                Console.ReadKey();

            }
        }
    }
}

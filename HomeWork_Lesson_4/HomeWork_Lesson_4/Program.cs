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
                Departament[] dArray = new Departament[2]
                {
                    new Departament("Бухгалтерия", DateTime.Today),
                    new Departament("ИТ", DateTime.Today),
                };


                //Departament dep01 = new Departament("Бухгалтерия", DateTime.Today);
                //Departament dep02 = new Departament("ИТ", DateTime.Today);

                Employee[] eArray = new Employee[3]
                {
            new Employee("Иван", "Иванов","Иванович",1500),
            new Employee("Петр", "Петров","Петрович",2000),
            new Employee("Василий", "Васильев","Васильевич",1000),
                };
                var x = new Employee("Генадий", "Генадьев", "Генадиевич", 1000);

                EmployeeList eList = new EmployeeList(eArray, dArray);
                eList.AddEmployee(x);
                Console.WriteLine(Departament.id+" "+dArray[0].name);
                Console.WriteLine(dArray[1].name);
                //Console.WriteLine(eList);
                //Console.WriteLine(dep01.id);
                //Console.WriteLine(dep02.id);

                //Console.WriteLine(eList. //GetEnumerator.dArray[0].id);

                foreach (Employee p in eList)
                {
                    Console.WriteLine(p.name + " " + p.surname);
                    Console.WriteLine(Departament.id);
                }
                Console.ReadKey();

            }
        }
    }
}

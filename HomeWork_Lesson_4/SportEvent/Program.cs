﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEvent
{
    //3. Реализовать программу “Отсев экстремальных оценок” используя List<int> Спортивное соревнование. Система предлагает выставить оценки.
    //Судьи выставляют шесть оценок. Исключаются 1 максимальная и 1. Обратите внимание, нужно получить список без максимальной и минимальной оценки.
    //Желательно сделать, чтобы функции передавался список и возвращался обработанный список. минимальная оценки. Выводится итоговая последовательность.

    class Program
    {
        static void Main(string[] args)
        {
            var gradeList = new List<int>();
            Console.Clear();
            GradeInput(ref gradeList);
            Judge(ref gradeList);
            Console.Write("Оценки судей: ");
            foreach (int i in gradeList)
                Console.Write($"{i} ");
            Judge(ref gradeList);
            Console.WriteLine("Результат соревнований: {0}", gradeList.Average() );
            Console.ReadKey();

        }
        public static void GradeInput(ref List<int> gradeList)
        {
            while(gradeList.Count() != 6)
            { 
            Console.Write("Введите оценку: ");
            int grade;
            if(int.TryParse(Console.ReadLine(), out grade))
                gradeList.Add(grade);
            }
        }
        public static void Judge(ref List<int> gradeList)
        {
            gradeList.Remove(gradeList.Max());
            gradeList.Remove(gradeList.Min());
        }

    }
}
//1. Создание собственного класса.Создайте собственный класс Employer содержащий поля зарплата, имя, должность.Реализуйте методы "Показать данные", "Изменить должность", "Увеличить зарплату".
//2. Реализовать программу “Средний уровень заработной платы”. Вводятся зарплаты 7 сотрудников.Функция принимает List<int> данных и возвращает на выходе среднее значение заработной платы.
//3. Реализовать программу “Отсев экстремальных оценок” используя List<int> Спортивное соревнование. Система предлагает выставить оценки. Судьи выставляют шесть оценок. Исключаются 1 максимальная и 1. Обратите внимание, нужно получить список без максимальной и минимальной оценки. Желательно сделать, чтобы функции передавался список и возвращался обработанный список. минимальная оценки. Выводится итоговая последовательность.

//Дополнительное задание
//Создайте класс - EmployeeList (может наследовать от интерфейса IEnumerable). Создайте класс Employee вида:
//Id int, - уникальный ключ - генерируется автоматически внутри EmployeeList
//Name string,
//Surname string,
//Patronymic string,
//FullName string, - ФИО
//DepartmentId int, - значение ключа одной из записей списка департаментов(Department.Id)
//IsFired false,
//Salary double,
//DateHired DateTime,
//DateFired DateTime? - nullable datetime(сслка в описании на Nullable типы)

//EmployeeList должен содержать в себе список сотрудников, типа Employee, а так же список департаментов Department, вида:
//Id int, - уникальный ключ - генерируется автоматически внутри EmployeeList
//Name string,
//DateCreate DateTime

//Класс EmployeeList должен уметь:
//- добавлять новые сущности в список сотрудников(при добавлении повторных записей, запись не доблжна быть добавлена)
//- добавлять новые департаменты(при добавлении повторных записей, запись не доблжна быть добавлена)
//- изменять фамилию, имя или отчество сотрудника по Id и по ФИО(передаются в функцию, должна быть перегрузка)
//- изменять имя департамента по Id и по имени(передаются в функцию, должна быть перегрузка)
//- удалять сотрудника по Id или ФИО(передаются в функцию, должна быть перегрузка)
//- удалять департамент по Id или имени(передаются в функцию, должна быть перегрузка)
//- считать средню зарплату всех работников
//- считать общую зарплату всех работников
//- считать среднюю зарплату по департаменту(Id передается в функцию)
//- считать общую зарплату по департаменту(Id передается в функцию)
//- считать количество сотрудников(всего)
//- считать количество сотрудников в департаментах(во всех сразу)
//- считать количество сотрудников в департаменте(Id передается в функцию)

//Результат работы каждой функции нужно выводить в консоли, например: Количество сотрудников в департаменте "Департамент развития бизнеса" - 10.
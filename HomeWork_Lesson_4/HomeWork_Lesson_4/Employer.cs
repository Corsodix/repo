using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson_4
{
    //1. Создание собственного класса.Создайте собственный класс Employer содержащий поля зарплата, имя, должность.
    //    Реализуйте методы "Показать данные", "Изменить должность", "Увеличить зарплату".
    public class Employer
    {
        //1. Создание собственного класса.Создайте собственный класс Employer содержащий поля зарплата, имя, должность.
        //    Реализуйте методы "Показать данные", "Изменить должность", "Увеличить зарплату".
        public int id;
        public string name;
        public string surname;
        public string patornymic;
        public string position;
        public double salary;
        public bool isFired { get { return isFired; } set { isFired = value; } }
        public string fullname { get { return $"{surname} {name} {patornymic}"; } }
        //DepartmentId int, - значение ключа одной из записей списка департаментов(Department.Id)
        public Employer(string name, string surname, string patornymic, string position, double salary)
        {
            this.name = name;
            this.surname = surname;
            this.patornymic = patornymic;
            this.position = position;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"{surname} {name} {patornymic} должность: {position} зарплата: {salary}";
        }
        public void ChangePosition(ref Employer employer, string _position)
        {
            employer.position = _position;

        }
        public void ChangeSalary(ref Employer _employer, double _salary)
        {
            _employer.salary = _salary;
        }
    }
}

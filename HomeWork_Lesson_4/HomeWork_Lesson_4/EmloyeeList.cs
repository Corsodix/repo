using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson_4
{
    //    Создайте класс - EmployeeList(может наследовать от интерфейса IEnumerable). Создайте класс Employee вида:
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


        
    public class Employee
    {
        //Доп задание сделать так и не получилось

        public static int id;
        public string name;
        public string surname;
        public string patornymic;
        public double salary;
        public bool isFired { get { return isFired; } set { isFired = value; } }
        public string fullname { get { return $"{surname} {name} {patornymic}"; } }
        public static int depId;
        public string dep;
        //DepartmentId int, - значение ключа одной из записей списка департаментов(Department.Id)
        public Employee(string name, string surname, string patornymic, double salary)
        {
            this.name = name;
            this.surname = surname;
            this.patornymic = patornymic;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"{surname} {name} {patornymic} зарплата: {salary}";
        }
        public void ChangeSalary(ref Employee _employer, double _salary)
        {
            _employer.salary = _salary;
        }
    }
    public class Departament
    {
        public static int id;
        public string name;
        public DateTime dateCreated; 

        public Departament(string name, DateTime dateCreated)
        {
            this.name = name;
            this.dateCreated = dateCreated;
        }
    }
    public class EmployeeList : IEnumerable
    {
        public Employee[] eList;
        private Departament[] dList;

        public EmployeeList(Departament[] dArray)
        {
            var rnd = new Random();
            dList = new Departament[dArray.Length];
            for (int i = 0; i < dArray.Length; i++)
            {
                dList[i] = dArray[i];
                Departament.id++;
            }


        }
        public void AddEmployee(Employee _employee)
        {
            Array.Resize<Employee>(ref eList, eList.Length + 1);
            eList.SetValue(_employee, eList.Length-1);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public EmployeeEnum GetEnumerator()
        {
            return new EmployeeEnum(eList);
        }
    }
    public class EmployeeEnum : IEnumerator
    {
        public Employee[] eList;
        int id = -1;
        public EmployeeEnum(Employee[] list)
        {
            eList = list;
        }
        public bool MoveNext()
        {
            id++;
            return (id < eList.Length);
        }
        public void Reset()
        {
            id = -1;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Employee Current
        {
            get
            {
                try
                {
                    return eList[id];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}

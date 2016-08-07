using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson_2
{
    class UserBase
    {
        public enum userBase : int
        {
            Admin = 1,
            User = 4,
            Guest = 7
        }
        public string login, password;
        public void LoginInput()
        {
            Console.Write("Введите ваш логин: ");
            login = Console.ReadLine();
            Console.Write("Введите ваш пароль: ");
            password = Console.ReadLine();
        }

    }
}

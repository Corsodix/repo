using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_Lesson_2
{
    class Authentication : UserBase
    {

        public static bool PassCheck(/*string _login, string _password*/)
        {
            Console.Clear();
            bool result = false;
            var address = "не хранилище паролей.txt";
            StreamReader passFile = new StreamReader(address); //создаем ссылку на фаил
            string pStr;
            List<string> pList = new List<string>();
            while ((pStr = passFile.ReadLine()) != null) //создаем список строк из фаила, до пустой строки
                pList.Add(pStr);

            UserBase logIn = new UserBase(); 
            logIn.LoginInput();                     //запрашиваем логин и пароль
            for (int i = 0; i < pList.Count; i++) // проходим циклом по всем логинам и паролям в фаиле
            {
                if (logIn.login == pList[(int)userBase.Admin]) // если введеный логин равен логину в фаиле
                {
                    if (logIn.password == pList[(int)userBase.Admin + 1]) //проверям пароль
                    {
                        Console.WriteLine("Welcome Admin!");
                        result = true;
                    }
                    else Console.WriteLine("Incorrect password!");
                    break;
                }
                else if (logIn.login == pList[(int)userBase.User])
                {
                    if (logIn.password == pList[(int)userBase.User + 1])
                    {
                        Console.WriteLine("Welcome User!");
                        result = true;
                    }
                    else Console.WriteLine("Incorrect password!");
                    break;
                }
                else if (logIn.login == pList[(int)userBase.Guest]) //у гостя нет проверки на пароль
                {
                    Console.WriteLine("Welcome Guest!");
                    result = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect login!"); //если введеный не обнаружен в списке, пишем что логин не верен
                    break;
                }
            }
            return result; //выводим результат
        }
    }
}

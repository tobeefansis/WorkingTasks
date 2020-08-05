using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;

namespace Task7
{
    public enum AccountType
    {
        User, Admin
    }
    public abstract class AbstractUser
    {
        /* Создать абстрактный класс AbstractUser и объявить в нем:
         • Защищенным поле accountType типа AccountType
         • Публичное свойство AccountType типа AccountType, обуспечив через него достук к полю accountType только для чтения*/

        AccountType accountType;

        public AccountType AccountType { get => accountType; private protected set => accountType = value; }
    }
    public class User : AbstractUser
    {
        /*Создать класс User и наследовать его от AbstractUser
        • Конструктор по умолчанию, инициализирующий поле accountType значением AccountType.User
        • Закрытый метод с сигнатурой void ShowMessage(string, string), который выводит информацию об обновлении(название обновления и его описание)
        • Метод ListenUpdates, который принимает в качестве параметра объект типа Application*/
        public User()
        {
            AccountType = AccountType.User;
        }
        void ShowMessage(string updateName, string updateDescription)
        {
            ConsoleLogger.StartBlock(ConsoleColor.Cyan);
            ConsoleLogger.LogCenter(updateName, ConsoleColor.Green, ConsoleColor.Cyan);
            ConsoleLogger.Log(updateDescription, background: ConsoleColor.Cyan);
            ConsoleLogger.EndBlock(ConsoleColor.Cyan);
        }
        public void ListenUpdates(Application application)
        {
            application.OnUpdateRelease += ShowMessage;
        }
    }

    public class Admin : AbstractUser
    {
        /* Создать класс Admin и наследовать его от AbstractUser
         • Создать конструктор по умолчанию, инициализирующий поле accountType значением AccountType.Admin*/
        public Admin()
        {
            AccountType = AccountType.Admin;
        }
    }

    public class Application
    {
        /* Создать класс Application со следующими полями и методами:
         • Открытый делегат с сигнатурой void MessageDelegate(string, string)
         • Открытый событие event MessageDelegate OnUpdateRelease
         • Открытый метод CreateUpdate(AccountType accountType, string updateName, string updateDescription)
             в котором при условии, что accountType соответствует администратору, вызывать событие(с передачей 
        в него updateName и updateDescription)*/
        public delegate void MessageDelegate(string t, string a);
        public event MessageDelegate OnUpdateRelease;
        public void CreateUpdate(AccountType accountType, string updateName, string updateDescription)
        {
            if (accountType == AccountType.Admin)
            {
                OnUpdateRelease?.Invoke(updateName, updateDescription);

            }
        }

    }
}

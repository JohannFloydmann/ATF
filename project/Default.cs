using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal abstract class Default
    {
        public static string _loginDefault = "Логин";
        public static string _passwordDefault = "Пароль";
        public static string _emailDefault = "Email";
        public static string _phoneNumberDefault = "Номер телефона";
        public static string _nameDefault = "Имя";
        public static string _surnameDefault = "Фамилия";
        public static string _addOwnDefault = "Сумма";
        public static string _receiverPhoneNumberDefault = "Номер получателя";
        public static string _currentPasswordDefault = "Текущий пароль";

        public enum Data { 
            Логин,
            Пароль,
            Имя,
            Телефон,
            Email,
        }
    }
}

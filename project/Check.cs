using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project
{
    internal class Check : Default
    {
        internal static bool LoginCheck(string login)
        {
            if (login == _loginDefault || login == "")
            {
                MessageBox.Show("Введите логин", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (login.IndexOf(' ') > -1)
            {
                MessageBox.Show("Введите логин без пробела", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return LoginExistsCheck(login);
        }
        internal static bool PasswordCheck(string password)
        {
            if (password == _passwordDefault || password == "")
            {
                MessageBox.Show("Введите пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (password.IndexOf(' ') > -1)
            {
                MessageBox.Show("Введите пароль без пробелов", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return PasswordStrenthCheck(password);
        }
        internal static bool NameCheck(string name)
        {
            if (name == _nameDefault || name == _surnameDefault || name == "")
            {
                MessageBox.Show("Введите имя и фамилию", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        internal static bool EmailCheck(string email)
        {
            if (email == _emailDefault || email == "")
            {
                MessageBox.Show("Введите email", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (email.IndexOf(' ') > -1)
            {
                MessageBox.Show("Введите email без пробелов", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (email.IndexOf('@') < 0)
            {
                MessageBox.Show("Введите корректный email", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        internal static bool PhoneNumberCheck(string phoneNumber)
        {
            if (phoneNumber == _phoneNumberDefault || phoneNumber == "")
            {
                MessageBox.Show("Введите номер телефона", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (phoneNumber.IndexOf(' ') > -1)
            {
                MessageBox.Show("Введите номер телефона без пробелов", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (char digit in phoneNumber)
            {
                if (!ContainsDigit(Convert.ToString(digit)))
                {
                    return false;
                }
            }
            return PhoneNumberExistsCheck(phoneNumber);
        }
        private static bool LoginExistsCheck(string login)
        {
            DataTable loginCheckDataTable = new DataTable();
            SqlCommand cmd = new SqlCommand($"SELECT u_login FROM USERS WHERE u_login = @login", LoginForm.dataBase.GetConnection());
            cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            LoginForm.adapter.SelectCommand = cmd;
            LoginForm.adapter.Fill(loginCheckDataTable);
            if (loginCheckDataTable.Rows.Count > 0)
            {
                loginCheckDataTable.Dispose();
                MessageBox.Show($"Такой логин уже используется. Попробуйте другой", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                loginCheckDataTable.Dispose();
                return true;
            }
                
        }
        private static bool PhoneNumberExistsCheck(string phoneNumber)
        {
            DataTable phoneNumberCheckDataTable = new DataTable();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM USERS WHERE u_phoneNumber = @number", LoginForm.dataBase.GetConnection());
            cmd.Parameters.Add("@number", SqlDbType.VarChar).Value = phoneNumber;
            LoginForm.adapter.SelectCommand = cmd;
            LoginForm.adapter.Fill(phoneNumberCheckDataTable);
            if (phoneNumberCheckDataTable.Rows.Count > 0)
            {
                phoneNumberCheckDataTable.Dispose();
                MessageBox.Show($"Такой номер телефона уже используется. Попробуйте другой", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                phoneNumberCheckDataTable.Dispose();
                return true;
            }

        }

        private static bool PasswordStrenthCheck(string pass)
        {
            int strength = 0;
            if (ContainsDigit(pass)) strength++;
            if (ContainsLowerLetter(pass)) strength++;
            if (ContainsPunctuation(pass)) strength++;
            if (ContainsSeparator(pass)) strength++;
            if (ContainsUpperLetter(pass)) strength++;

            if (strength >= 2) return true;
            MessageBox.Show("Пароль слишком легкий");
            return false;
        }
        private static bool ContainsLowerLetter(string pass)
        {
            foreach (char c in pass)
            {
                if ((Char.IsLetter(c)) && (Char.IsLower(c)))
                    return true;
            }
            return false;
        }
        private static bool ContainsUpperLetter(string pass)
        {
            foreach (char c in pass)
            {
                if ((Char.IsLetter(c)) && (Char.IsUpper(c)))
                    return true;
            }
            return false;
        }
        private static bool ContainsDigit(string pass)
        {
            foreach (char c in pass)
            {
                if (Char.IsDigit(c))
                    return true;
            }
            return false;
        }
        private static bool ContainsPunctuation(string pass)
        {
            foreach (char c in pass)
            {
                if (Char.IsPunctuation(c))
                    return true;
            }
            return false;
        }
        private static bool ContainsSeparator(string pass)
        {
            foreach (char c in pass)
            {
                if (Char.IsSeparator(c))
                    return true;
            }
            return false;
        }
    }
}


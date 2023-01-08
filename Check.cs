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
            if (login == _loginDefault)
            {
                MessageBox.Show("Введите логин", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (login.IndexOf(' ') > -1)
            {
                MessageBox.Show("Введите логин без пробела", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return LoginExistsCheck("логин");
        }
        internal static bool PasswordCheck(string password)
        {
            if (password == _passwordDefault)
            {
                MessageBox.Show("Введите пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (password.IndexOf(' ') > -1)
            {
                MessageBox.Show("Введите пароль без пробела", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return PasswordStrenthCheck(password);
        }
        internal static bool NameCheck(string name)
        {
            if (name == _nameDefault || name == _surnameDefault)
            {
                MessageBox.Show("Введите имя или фамилию", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (name.IndexOf(' ') > -1)
            {
                MessageBox.Show("Введите имя или фамилию без пробела", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        internal static bool EmailCheck(string email)
        {
            if (email == _emailDefault)
            {
                MessageBox.Show("Введите email", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (email.IndexOf(' ') > -1)
            {
                MessageBox.Show("Введите email без пробела", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (phoneNumber == _phoneNumberDefault)
            {
                MessageBox.Show("Введите номер телефона", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (phoneNumber.IndexOf(' ') > -1)
            {
                MessageBox.Show("Введите номер телефона без пробела", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (char digit in phoneNumber)
            {
                if (!ContainsDigit(Convert.ToString(digit)))
                {
                    return false;
                }
            }
            return PhoneNumberExistsCheck("номер телефона");
        }
        private static bool LoginExistsCheck(string type)
        {
            DataTable loginCheckDataTable = new DataTable();
            SqlCommand cmd = new SqlCommand($"SELECT u_login FROM USERS WHERE u_login = @login", LoginForm.dataBase.GetConnection());
            cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = Program.signUpForm.loginField.Text;
            LoginForm.adapter.SelectCommand = cmd;
            LoginForm.adapter.Fill(loginCheckDataTable);
            if (loginCheckDataTable.Rows.Count > 0)
            {
                loginCheckDataTable.Dispose();
                MessageBox.Show($"Такой {type} уже используется. Попробуй другой", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                loginCheckDataTable.Dispose();
                return true;
            }
                
        }
        private static bool PhoneNumberExistsCheck(string type)
        {
            DataTable phoneNumberCheckDataTable = new DataTable();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM USERS WHERE u_phoneNumber = @number", LoginForm.dataBase.GetConnection());
            cmd.Parameters.Add("@number", SqlDbType.VarChar).Value = Program.signUpForm.numberField.Text;
            LoginForm.adapter.SelectCommand = cmd;
            LoginForm.adapter.Fill(phoneNumberCheckDataTable);
            if (phoneNumberCheckDataTable.Rows.Count > 0)
            {
                phoneNumberCheckDataTable.Dispose();
                MessageBox.Show($"Такой {type} уже используется. Попробуй другой", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (strength >= 3) return true;
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


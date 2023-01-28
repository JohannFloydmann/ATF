using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project
{
    public partial class SignUpForm : KryptonForm
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            TextBoxHint.HideHint(loginField, Check._loginDefault);
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            TextBoxHint.ShowHint(loginField);
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            TextBoxHint.HideHint(passwordField, Check._passwordDefault);
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            TextBoxHint.ShowHint(passwordField);
        }

        private void nameField_Enter(object sender, EventArgs e)
        {
            TextBoxHint.HideHint(nameField, Check._nameDefault);
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            TextBoxHint.ShowHint(nameField);
        }

        private void surnameField_Leave(object sender, EventArgs e)
        {
            TextBoxHint.ShowHint(surnameField);
        }

        private void surnameField_Enter(object sender, EventArgs e)
        {
            TextBoxHint.HideHint(surnameField, Check._surnameDefault);
        }

        private void emailField_Leave(object sender, EventArgs e)
        {
            TextBoxHint.ShowHint(emailField);
        }

        private void emailField_Enter(object sender, EventArgs e)
        {
            TextBoxHint.HideHint(emailField, Check._emailDefault);
        }

        private void numberField_Enter(object sender, EventArgs e)
        {
            TextBoxHint.HideHint(numberField, Check._phoneNumberDefault);
        }

        private void numberField_Leave(object sender, EventArgs e)
        {
            TextBoxHint.ShowHint(numberField);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string login = loginField.Text;  //объявление переменных
            string password = passwordField.Text;
            string name = nameField.Text;
            string surname = surnameField.Text;
            string email = emailField.Text;
            string phoneNumber = numberField.Text;
            
            if (!Check.LoginCheck(login) || !Check.PasswordCheck(password) || !Check.NameCheck(name) || !Check.NameCheck(surname) || !Check.EmailCheck(email) || !Check.PhoneNumberCheck(phoneNumber))
                return;

            SqlCommand cmd = new SqlCommand("INSERT INTO USERS(u_login, u_password, u_name, u_surname, u_email, u_phoneNumber) VALUES (@login, @password, @name, @surname, @email, @phoneNumber)", LoginForm.dataBase.GetConnection());
            cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = login;  //если в документации написано "рекомендуется", значит это критически необходимо для работы программы))
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@surname", SqlDbType.VarChar).Value = surname;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = phoneNumber;

            LoginForm.dataBase.OpenConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан");
                Program.loginForm.loginField.Text = this.loginField.Text;
                this.Hide();
                Program.loginForm.Show();
            }
            LoginForm.dataBase.CloseConnection();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.loginForm.Show();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace project
{
    public partial class LoginForm : KryptonForm
    {
        public static DB dataBase = new DB();
        public static SqlDataAdapter adapter = new SqlDataAdapter();
        public static DataTable userDataTable = new DataTable();
        
        
        public LoginForm()
        {
                
            InitializeComponent();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e) 
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM USERS WHERE u_login = @login AND u_password = @password", dataBase.GetConnection());
            cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = loginField.Text;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordField.Text;

            adapter.SelectCommand = cmd;
            adapter.Fill(userDataTable);
            if (userDataTable.Rows.Count > 0)
            {
                Program.currentUser.Login = loginField.Text;
                userDataTable.Clear();
                Program.signUpForm.Hide();
                Program.mainForm.Show();
                this.Hide();               
            }
            else
            {
                MessageBox.Show("Не удалось ввойти в аккаунт", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
                
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {

        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            TextBoxHint.ShowHint(loginField);
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            TextBoxHint.HideHint(loginField, "Логин");
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            TextBoxHint.ShowHint(passwordField);
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            TextBoxHint.HideHint(passwordField, "Пароль");
        }

        private void loginToSignUp_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            Program.signUpForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_palette_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }
    }
}

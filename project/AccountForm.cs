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
    public partial class AccountForm : KryptonForm
    {
        private AccountInfo[] accountInfos = new AccountInfo[(int)Default.Data.Email + 1];
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
        }
        public void createItems()
        {
            containerPanel.Controls.Clear();
            for(int i = 0; i<accountInfos.Length; i++)
            {
                accountInfos[i] = new AccountInfo();
                accountInfos[i].DataType = ((Default.Data)i);
                switch ((Default.Data)i)
                {
                    case Default.Data.Email:
                        accountInfos[i].Data = Program.currentUser.Email;
                        break;
                    case Default.Data.Имя:
                        accountInfos[i].Data = Program.currentUser.FullName;
                        break;
                    case Default.Data.Логин:
                        accountInfos[i].Data = Program.currentUser.Login;
                        break;
                    case Default.Data.Пароль:
                        accountInfos[i].Data = Program.currentUser.Password;
                        break;
                    case Default.Data.Телефон:
                        accountInfos[i].Data = Program.currentUser.PhoneNumber;
                        break;
                }
                containerPanel.Controls.Add((Control)accountInfos[i]);
            } 
        }

        private void backArrowPicture_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainForm.Show();
        }

        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (currentPasswordField.Text == Program.currentUser.Password)
            {
                string[] EditedData = new string[(int)Default.Data.Email + 1];
                foreach (AccountInfo accountInfo in accountInfos)
                {
                    if (accountInfo.ifEdit)
                    {
                        EditedData[(int)accountInfo.DataType] = accountInfo.editField.Text;
                        accountInfo.ifEdit = false;
                        accountInfo.editBox.Image = project.Properties.Resources.edit;
                        accountInfo.editField.Text = "";
                        accountInfo.infoDataLabel.Visible = true;
                        accountInfo.editField.Visible = false;
                    }
                }
                for (int i = 0; i < EditedData.Length; i++)
                {
                    if (EditedData[i] != null)
                    {
                        switch (i)
                        {
                            case (int)Default.Data.Логин:
                                if (Check.LoginCheck(EditedData[i]))
                                {
                                    LoginForm.dataBase.updateDataByLogin(EditedData[i], Program.currentUser.Login, "u_login");
                                    Program.currentUser.Login = EditedData[i];
                                    MessageBox.Show($"{(Default.Data)i} успешно изменен", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;

                            case (int)Default.Data.Пароль:
                                if (Check.PasswordCheck(EditedData[i]))
                                {
                                    LoginForm.dataBase.updateDataByLogin(EditedData[i], Program.currentUser.Login, "u_password");
                                    Program.currentUser.Password = EditedData[i];
                                    MessageBox.Show($"{(Default.Data)i} успешно изменен", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;

                            case (int)Default.Data.Телефон:
                                if (Check.PhoneNumberCheck(EditedData[i]))
                                {
                                    LoginForm.dataBase.updateDataByLogin(EditedData[i], Program.currentUser.Login, "u_phoneNumber");
                                    Program.currentUser.PhoneNumber = EditedData[i];
                                    MessageBox.Show($"{(Default.Data)i} успешно изменен", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;

                            case (int)Default.Data.Имя:
                                if (Check.NameCheck(EditedData[i]))
                                {
                                    string[] name = EditedData[i].Split();
                                    LoginForm.dataBase.updateDataByLogin(name[0], Program.currentUser.Login, "u_name");
                                    LoginForm.dataBase.updateDataByLogin(name[1], Program.currentUser.Login, "u_surname");
                                    Program.currentUser.FullName = EditedData[i];
                                    Program.currentUser.Name = name[0];
                                    Program.currentUser.Surname = name[1];
                                    MessageBox.Show($"{(Default.Data)i} успешно изменен", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;

                            case (int)Default.Data.Email:
                                if (Check.EmailCheck(EditedData[i]))
                                {
                                    LoginForm.dataBase.updateDataByLogin(EditedData[i], Program.currentUser.Login, "u_email");
                                    Program.currentUser.Email = EditedData[i];
                                    MessageBox.Show($"{(Default.Data)i} успешно изменен", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                        }
                    }
                }
                TextBoxHint.ShowHint(currentPasswordField, Check._currentPasswordDefault);
                this.Hide();
                Program.mainForm.Show();
            }
            else
                MessageBox.Show("Введите корректный текущий пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void currentPasswordField_Enter(object sender, EventArgs e)
        {
            TextBoxHint.HideHint(currentPasswordField, Check._currentPasswordDefault);
        }

        private void currentPasswordField_Leave(object sender, EventArgs e)
        {
            TextBoxHint.ShowHint(currentPasswordField);
        }
    }
}

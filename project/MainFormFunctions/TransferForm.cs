using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace project.MainFormFunctions
{
    public partial class TransferForm : KryptonForm
    {
        public TransferForm()
        {
            InitializeComponent();
        }

        private void TransferForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void choiceDropButton_Click(object sender, EventArgs e)
        {

        }

        private void kryptonContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void backArrowPicture_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainForm.Show();
        }

        private void transferAmountField_TextChanged(object sender, EventArgs e)
        {

        }

        private void transferAmountField_Leave(object sender, EventArgs e)
        {
            TextBoxHint.ShowHint(transferAmountField);
        }

        private void transferAmountField_Enter(object sender, EventArgs e)
        {
            TextBoxHint.HideHint(transferAmountField, Check._addOwnDefault);
        }

        private void receiverPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void receiverPhoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            TextBoxHint.ShowHint(receiverPhoneNumberTextBox);
        }

        private void receiverPhoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            TextBoxHint.HideHint(receiverPhoneNumberTextBox, Check._receiverPhoneNumberDefault);
        }

        private void transferAcceptButton_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(transferAmountField.Text, out int transferAmount))
            {
                MessageBox.Show("Введите корректную сумму!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string phoneNumber = receiverPhoneNumberTextBox.Text;

            DataTable transferDataTable = new DataTable();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM USERS WHERE u_phoneNumber = @number", LoginForm.dataBase.GetConnection());
            cmd.Parameters.Add("@number", SqlDbType.VarChar).Value = phoneNumber;

            LoginForm.adapter.SelectCommand = cmd;
            LoginForm.adapter.Fill(transferDataTable);
            if (transferDataTable.Rows.Count > 0)
            {
                transferDataTable.Dispose();
                this.Hide();
                Program.mainForm.Show();
                LoginForm.dataBase.Transfer(transferAmount, phoneNumber);
            }
            else
            {
                transferDataTable.Dispose();
                MessageBox.Show("Номер телефона не найден!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signUpLabel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

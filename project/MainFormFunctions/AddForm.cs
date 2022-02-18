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

namespace project.MainFormFunctions
{
    public partial class AddForm : KryptonForm
    {
        internal static bool _isIncrease;
        public AddForm(bool isIncrease)
        {
            InitializeComponent();
            _isIncrease = isIncrease;
        }

        private void add1000Button_Click(object sender, EventArgs e)
        {
            //реализовать пополнение u_currentmoney и u_increasedMoney 
            Program.mainForm.Show();
            this.Hide();
            if (_isIncrease == true)
                LoginForm.dataBase.EditDataAdd(1000);
            else
                LoginForm.dataBase.EditDataOut(1000);
        }

        private void addOwnField_Leave(object sender, EventArgs e)
        {
            TextBoxHint.ShowHint(addOwnField);
        }

        private void addOwnField_Enter(object sender, EventArgs e)
        {
            TextBoxHint.HideHint(addOwnField, Check._addOwnDefault);
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void add5000Button_Click(object sender, EventArgs e)
        {
            //реализовать пополнение u_currentmoney и u_increasedMoney 
            Program.mainForm.Show();
            this.Hide();
            if (_isIncrease == true)
                LoginForm.dataBase.EditDataAdd(5000);
            else
                LoginForm.dataBase.EditDataOut(5000);
        }

        private void add10000Button_Click(object sender, EventArgs e)
        {
            //реализовать пополнение u_currentmoney и u_increasedMoney 
            Program.mainForm.Show();
            this.Hide();
            if (_isIncrease == true)
                LoginForm.dataBase.EditDataAdd(10000);
            else
                LoginForm.dataBase.EditDataOut(10000);
        }

        private void add50000Button_Click(object sender, EventArgs e)
        {
            //реализовать пополнение u_currentmoney и u_increasedMoney 
            Program.mainForm.Show();
            this.Hide();
            if (_isIncrease == true)
                LoginForm.dataBase.EditDataAdd(50000);
            else
                LoginForm.dataBase.EditDataOut(50000);
        }

        private void addOwnButton_Click(object sender, EventArgs e)
        {
            //реализовать пополнение u_currentmoney и u_increasedMoney 
            Program.mainForm.Show();
            this.Hide();
            if (Int32.TryParse(Program.addForm.addOwnField.Text, out int sum))
            {
                if (_isIncrease == true)
                    LoginForm.dataBase.EditDataAdd(sum);
                else
                    LoginForm.dataBase.EditDataOut(sum);
            }
        }

        private void backArrowPicture_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainForm.Show();
        }
    }
}

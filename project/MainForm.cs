using System;
using project.MainFormFunctions;
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
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            /*DataTable userDataTable = new DataTable();

            SqlCommand cmd = new SqlCommand($"SELECT * FROM USERS WHERE u_login = {Program.loginForm.loginField.Text}", LoginForm.dataBase.GetConnection());
            
            
            LoginForm.adapter.SelectCommand = cmd;

            LoginForm.adapter.SelectCommand = cmd;
            LoginForm.adapter.Fill(LoginForm.userDataTable*/
            
            InitializeComponent();
        }

        private bool _isAddFormOpened = false;
        private bool _isOutFormOpened = false;

        private void LoginForm_palette_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm._isIncrease = true;
            if (_isAddFormOpened == false)
            {
                Program.addForm = new AddForm(true);
                Program.addForm.Show();
                this.Hide();
                _isAddFormOpened=true;
            }
            else
            {
                this.Hide();
                Program.addForm.actionLabel.Text = "Пополнение";
                Program.addForm.actionLabel.Location = new Point(77, 22);
                Program.addForm.Show();
            }
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            AddForm._isIncrease = false;
            if (_isOutFormOpened == false)
            {
                Program.addForm = new AddForm(false);
                Program.addForm.Show();
                this.Hide();
                _isOutFormOpened=true;
            }
            else
            {
                this.Hide();
                Program.addForm.actionLabel.Text = "Снятие";
                Program.addForm.actionLabel.Location = new Point(145, 22);
                Program.addForm.Show();
            }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            Program.transferForm = new TransferForm();
            Program.transferForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoginForm.dataBase.GetData();
        }

        private void backArrowPicture_Click(object sender, EventArgs e)
        {
            Program.loginForm.loginField.Text = Check._loginDefault;
            Program.loginForm.passwordField.Text = Check._passwordDefault;
            Program.loginForm.passwordField.UseSystemPasswordChar = false;
            this.Hide();
            Program.loginForm.Show();
        }
        private void historyButton_Click(object sender, EventArgs e)
        {
            Program.historyForm = new HistoryForm();
            Program.historyForm.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}

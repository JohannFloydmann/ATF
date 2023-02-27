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
using project.historyControls;

namespace project
{
    public partial class HistoryForm : KryptonForm
    {
        internal Transactions transactions = new Transactions();
        internal Transfers transfers = new Transfers();

        public static DataTable historyDataTable = new DataTable();
        public HistoryForm()
        {
            InitializeComponent();
            LoginForm.dataBase.getHistory();
        }
        private void HistoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        internal void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            
        }

        internal void createItems()
        {
            transfers.transfersPanel.Controls.Clear();
            this.transactions.transactionPanel.Controls.Clear();
            LoginForm.dataBase.getHistory();
            Transaction[] transactions = new Transaction[historyDataTable.Rows.Count];
            bool isTransfer = true;
            for (int i = 0; i < transactions.Length; i++)
            {
                transactions[i] = new Transaction();
                DateTime dateTime = historyDataTable.Rows[i].Field<DateTime>("t_datetime").ToLocalTime();
                if (historyDataTable.Rows[i].Field<string>("t_sender") == Program.loginForm.loginField.Text)
                { // пользователь - отправитель
                    if(historyDataTable.Rows[i].Field<string>("t_reciever") == Program.AtmName)
                    {
                        transactions[i].Name = "Снятие";
                        transactions[i].Phone = Program.AtmName;
                        isTransfer = false;
                    }
                    else
                    {
                        transactions[i].Name = $"{LoginForm.dataBase.getDataByLogin(historyDataTable.Rows[i].Field<string>("t_reciever"), "u_name")} {LoginForm.dataBase.getDataByLogin(historyDataTable.Rows[i].Field<string>("t_reciever"), "u_surname")[0]}.";
                        transactions[i].Phone = LoginForm.dataBase.getDataByLogin(historyDataTable.Rows[i].Field<string>("t_reciever"), "u_phoneNumber");
                        isTransfer = true;
                    }
                    transactions[i].Image = global::project.Properties.Resources.redArrowDone;
                }
                else if(historyDataTable.Rows[i].Field<string>("t_reciever") == Program.loginForm.loginField.Text)
                {// пользователь - получатель
                    if (historyDataTable.Rows[i].Field<string>("t_sender") == Program.AtmName)
                    {
                        transactions[i].Name = "Пополнение";
                        transactions[i].Phone = Program.AtmName;
                        isTransfer = false;
                    }
                    else
                    {
                        transactions[i].Name = $"{LoginForm.dataBase.getDataByLogin(historyDataTable.Rows[i].Field<string>("t_sender"), "u_name")} {LoginForm.dataBase.getDataByLogin(historyDataTable.Rows[i].Field<string>("t_sender"), "u_surname")[0]}.";
                        transactions[i].Phone = LoginForm.dataBase.getDataByLogin(historyDataTable.Rows[i].Field<string>("t_sender"), "u_phoneNumber");
                        isTransfer = true;
                    }
                    transactions[i].Image = global::project.Properties.Resources.greenArrowDone;
                }
                transactions[i].Money = $"₸ {Convert.ToString(historyDataTable.Rows[i].Field<Int32>("t_amount").ToString("N0"))}";
                transactions[i].Date = dateTime.Date.ToString("dd.MM.yyyy");
                transactions[i].Time = dateTime.ToString("HH:mm");
                if(isTransfer)
                    transfers.transfersPanel.Controls.Add((Control)transactions[i]);
                else
                {
                    transactions[i].moneyLabel.Location = new Point(transactions[i].moneyLabel.Location.X + 15, transactions[i].moneyLabel.Location.Y);
                    this.transactions.transactionPanel.Controls.Add((Control)transactions[i]);
                }
                    
            }
        }

        private void leavePage(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainForm.Show();
        }

        private void transfersLabel_Click(object sender, EventArgs e)
        {
            addUserControl(transfers);
        }

        private void transactionsLabel_Click(object sender, EventArgs e)
        {
            addUserControl(transactions);
        }
    }
}

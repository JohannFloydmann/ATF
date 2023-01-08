using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace project
{
    public class DB
    {
        private static string _myPC = "DESKTOP-R9T8IE4\\SQLEXPRESS";
        private static string _stepPC = "201-8";
        SqlConnection _connection = new SqlConnection($@"Data Source={_stepPC};Initial Catalog=ATF_Bank; Integrated Security=True");

        public void OpenConnection()
        {
            if( _connection.State == System.Data.ConnectionState.Closed)
                _connection.Open();
        }
        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }

        public SqlConnection GetConnection() { return _connection; }
        public void GetData()
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM USERS WHERE u_login = @login", LoginForm.dataBase.GetConnection());
            cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = Program.loginForm.loginField.Text;
            LoginForm.adapter.SelectCommand = cmd;
            LoginForm.adapter.Fill(LoginForm.userDataTable);

            Program.mainForm.nameLabel.Text = $"{LoginForm.userDataTable.Rows[0].Field<string>("u_name")} {LoginForm.userDataTable.Rows[0].Field<string>("u_surname")}";
            Program.mainForm.numberLabel.Text = LoginForm.userDataTable.Rows[0].Field<string>("u_phoneNumber");
            Program.mainForm.moneyLabel.Text = $"₸ {LoginForm.userDataTable.Rows[0].Field<Int32>("u_currentMoney").ToString("N0")}";
            Program.mainForm.increasedMoneyLabel.Text = $"↑ {LoginForm.userDataTable.Rows[0].Field<Int32>("u_increasedMoney").ToString("N0")}";
            Program.mainForm.decreasedMoneyLabel.Text = $"↓ {LoginForm.userDataTable.Rows[0].Field<Int32>("u_decreasedMoney").ToString("N0")}";
            LoginForm.userDataTable.Clear();
        }
        public void EditDataAdd(int sum)
        {
            SqlCommand cmd = new SqlCommand($"UPDATE USERS SET u_currentMoney = u_currentMoney + {sum}, u_increasedMoney = u_increasedMoney + {sum} WHERE u_login = @login", LoginForm.dataBase.GetConnection());
            cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = Program.loginForm.loginField.Text;

            LoginForm.dataBase.OpenConnection();
            cmd.ExecuteNonQuery();
            LoginForm.dataBase.CloseConnection();

            GetData();
            MessageBox.Show("Средства добавлены на счет", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EditDataOut(int sum)
        {
            DataTable dt = new DataTable();
            SqlCommand cmdCheck = new SqlCommand($"SELECT u_currentMoney FROM USERS WHERE u_login = @login", LoginForm.dataBase.GetConnection());
            cmdCheck.Parameters.Add("@login", SqlDbType.VarChar).Value = Program.loginForm.loginField.Text;
            LoginForm.adapter.SelectCommand = cmdCheck;
            LoginForm.adapter.Fill(dt);
            if (sum > Convert.ToInt32(dt.Rows[0].Field<Int32>("u_currentMoney")))
            {
                MessageBox.Show("На счете недостаточно средств", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt.Dispose();
                return;
            }
            dt.Dispose();

            SqlCommand cmd = new SqlCommand($"UPDATE USERS SET u_currentMoney = u_currentMoney - {sum}, u_decreasedMoney = u_decreasedMoney + {sum} WHERE u_login = @login", LoginForm.dataBase.GetConnection());
            cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = Program.loginForm.loginField.Text;
            LoginForm.dataBase.OpenConnection();
            cmd.ExecuteNonQuery();
            LoginForm.dataBase.CloseConnection();
            GetData();
            MessageBox.Show("Заберите деньги", "Успех!", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void Transfer(int sum, string number)
        {
            SqlCommand cmdAdd = new SqlCommand($"UPDATE USERS SET u_currentMoney = u_currentMoney + {sum}, u_increasedMoney = u_increasedMoney + {sum} WHERE u_phoneNumber = @number", LoginForm.dataBase.GetConnection());
            cmdAdd.Parameters.Add("@number", SqlDbType.VarChar).Value = number;

            SqlCommand cmdOut = new SqlCommand($"UPDATE USERS SET u_currentMoney = u_currentMoney - {sum}, u_decreasedMoney = u_decreasedMoney + {sum} WHERE u_login = @login", LoginForm.dataBase.GetConnection());
            cmdOut.Parameters.Add("@login", SqlDbType.VarChar).Value = Program.loginForm.loginField.Text;

            LoginForm.dataBase.OpenConnection();
            cmdAdd.ExecuteNonQuery();
            cmdOut.ExecuteNonQuery();
            LoginForm.dataBase.CloseConnection();

            GetData();
            MessageBox.Show($"Средства переведены на счет {number}!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

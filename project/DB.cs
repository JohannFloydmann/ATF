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
        SqlConnection _connection = new SqlConnection($@"Data Source={_myPC};Initial Catalog=ATF_Bank; Integrated Security=True");

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
            cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = Program.currentUser.Login;
            LoginForm.userDataTable.Clear();
            LoginForm.adapter.SelectCommand = cmd;
            LoginForm.adapter.Fill(LoginForm.userDataTable);

            Program.currentUser.Login = LoginForm.userDataTable.Rows[0].Field<string>("u_login");
            Program.currentUser.Email = LoginForm.userDataTable.Rows[0].Field<string>("u_email"); 
            Program.currentUser.PhoneNumber = LoginForm.userDataTable.Rows[0].Field<string>("u_phoneNumber");
            Program.currentUser.Name = LoginForm.userDataTable.Rows[0].Field<string>("u_name");
            Program.currentUser.Surname = LoginForm.userDataTable.Rows[0].Field<string>("u_surname");
            Program.currentUser.FullName = $"{LoginForm.userDataTable.Rows[0].Field<string>("u_name")} {LoginForm.userDataTable.Rows[0].Field<string>("u_surname")}";
            Program.currentUser.Password = LoginForm.userDataTable.Rows[0].Field<string>("u_password");
            Program.currentUser.currentMoney = LoginForm.userDataTable.Rows[0].Field<Int32>("u_currentMoney").ToString("N0");

            Program.mainForm.nameLabel.Text = Program.currentUser.FullName;
            Program.mainForm.numberLabel.Text = Program.currentUser.PhoneNumber;
            Program.mainForm.moneyLabel.Text = $"₸ {LoginForm.userDataTable.Rows[0].Field<Int32>("u_currentMoney").ToString("N0")}";
            Program.mainForm.increasedMoneyLabel.Text = $"↑ {LoginForm.userDataTable.Rows[0].Field<Int32>("u_increasedMoney").ToString("N0")}";
            Program.mainForm.decreasedMoneyLabel.Text = $"↓ {LoginForm.userDataTable.Rows[0].Field<Int32>("u_decreasedMoney").ToString("N0")}";
            LoginForm.userDataTable.Clear();
        }
        public void EditDataAdd(int sum)
        {
            DateTime dateTime = DateTime.UtcNow;
            string sqlFormattedDate = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            SqlCommand cmd = new SqlCommand($"UPDATE USERS SET u_currentMoney = u_currentMoney + {sum}, u_increasedMoney = u_increasedMoney + {sum} WHERE u_login = @login", LoginForm.dataBase.GetConnection());
            cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = Program.currentUser.Login;

            //запись в историю
            SqlCommand cmdHistory = new SqlCommand($"INSERT INTO HISTORY (t_sender, t_reciever, t_amount, t_datetime) VALUES (@senderLogin, @recieverLogin, {sum}, @DateTime)", LoginForm.dataBase.GetConnection());
            cmdHistory.Parameters.Add("@senderLogin", SqlDbType.VarChar).Value = Program.AtmName;
            cmdHistory.Parameters.Add("@recieverLogin", SqlDbType.VarChar).Value = Program.currentUser.Login;
            cmdHistory.Parameters.Add("@DateTime", SqlDbType.SmallDateTime).Value = sqlFormattedDate;

            LoginForm.dataBase.OpenConnection();
            cmd.ExecuteNonQuery();
            cmdHistory.ExecuteNonQuery();
            LoginForm.dataBase.CloseConnection();

            GetData();
            MessageBox.Show("Средства добавлены на счет", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EditDataOut(int sum)
        {
            DateTime dateTime = DateTime.UtcNow;
            string sqlFormattedDate = dateTime.ToString("yyyy-MM-dd HH:mm:ss");

            DataTable dt = new DataTable();
            SqlCommand cmdCheck = new SqlCommand($"SELECT u_currentMoney FROM USERS WHERE u_login = @login", LoginForm.dataBase.GetConnection());
            cmdCheck.Parameters.Add("@login", SqlDbType.VarChar).Value = Program.currentUser.Login;
            LoginForm.userDataTable.Clear();
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
            cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = Program.currentUser.Login;

            // запись в историю
            SqlCommand cmdHistory = new SqlCommand($"INSERT INTO HISTORY (t_sender, t_reciever, t_amount, t_datetime) VALUES (@senderLogin, @recieverLogin, {sum}, @DateTime)", LoginForm.dataBase.GetConnection());
            cmdHistory.Parameters.Add("@recieverLogin", SqlDbType.VarChar).Value = Program.AtmName;
            cmdHistory.Parameters.Add("@senderLogin", SqlDbType.VarChar).Value = Program.currentUser.Login;
            cmdHistory.Parameters.Add("@DateTime", SqlDbType.SmallDateTime).Value = sqlFormattedDate;

            LoginForm.dataBase.OpenConnection();
            cmd.ExecuteNonQuery();
            cmdHistory.ExecuteNonQuery();
            LoginForm.dataBase.CloseConnection();
            GetData();
            MessageBox.Show("Заберите деньги", "Успех!", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void Transfer(int sum, string number)
        {
            DateTime dateTime = DateTime.UtcNow;
            string sqlFormattedDate = dateTime.ToString("yyyy-MM-dd HH:mm:ss");   
            Console.WriteLine(sqlFormattedDate);
            SqlCommand cmdAdd = new SqlCommand($"UPDATE USERS SET u_currentMoney = u_currentMoney + {sum}, u_increasedMoney = u_increasedMoney + {sum} WHERE u_phoneNumber = @number", LoginForm.dataBase.GetConnection());
            cmdAdd.Parameters.Add("@number", SqlDbType.VarChar).Value = number;

            SqlCommand cmdOut = new SqlCommand($"UPDATE USERS SET u_currentMoney = u_currentMoney - {sum}, u_decreasedMoney = u_decreasedMoney + {sum} WHERE u_login = @login", LoginForm.dataBase.GetConnection());
            cmdOut.Parameters.Add("@login", SqlDbType.VarChar).Value = Program.currentUser.Login; 

            SqlCommand findAccountByNumber = new SqlCommand($"SELECT u_login FROM USERS WHERE u_phoneNumber = {number}", LoginForm.dataBase.GetConnection());
            LoginForm.userDataTable.Clear();
            LoginForm.adapter.SelectCommand = findAccountByNumber;
            LoginForm.adapter.Fill(LoginForm.userDataTable);

            //запись в историю
            SqlCommand cmdHistory = new SqlCommand($"INSERT INTO HISTORY (t_sender, t_reciever, t_amount, t_datetime) VALUES (@senderLogin, @recieverLogin, {sum}, @DateTime)", LoginForm.dataBase.GetConnection());
            cmdHistory.Parameters.Add("@senderLogin", SqlDbType.VarChar).Value = Program.currentUser.Login; ;
            cmdHistory.Parameters.Add("@recieverLogin", SqlDbType.VarChar).Value = LoginForm.userDataTable.Rows[0].Field<string>("u_login");
            cmdHistory.Parameters.Add("@DateTime", SqlDbType.SmallDateTime).Value = sqlFormattedDate;

            LoginForm.dataBase.OpenConnection();
            cmdAdd.ExecuteNonQuery();
            cmdOut.ExecuteNonQuery();
            cmdHistory.ExecuteNonQuery();
            LoginForm.dataBase.CloseConnection();

            GetData();
            MessageBox.Show($"Средства переведены на счет {number}!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void getHistory()
        {
            SqlCommand cmdHistory = new SqlCommand($"SELECT * FROM HISTORY WHERE t_sender = @login OR t_reciever = @login ORDER BY t_datetime DESC", LoginForm.dataBase.GetConnection());
            cmdHistory.Parameters.Add("@login", SqlDbType.VarChar).Value = Program.currentUser.Login; ;
            HistoryForm.historyDataTable.Clear();
            LoginForm.adapter.SelectCommand = cmdHistory;
            LoginForm.adapter.Fill(HistoryForm.historyDataTable);
        }
        public string getDataByLogin(string Login, string Data)
        {
            SqlCommand cmdHistory = new SqlCommand($"SELECT {Data} FROM USERS WHERE u_login = @login", LoginForm.dataBase.GetConnection());
            cmdHistory.Parameters.Add("@login", SqlDbType.VarChar).Value = Login;
            cmdHistory.Parameters.Add("@data", SqlDbType.VarChar).Value = Data;
            LoginForm.userDataTable.Clear();
            LoginForm.adapter.SelectCommand = cmdHistory;
            LoginForm.adapter.Fill(LoginForm.userDataTable);

            string data = LoginForm.userDataTable.Rows[0].Field<string>(Data);
            LoginForm.userDataTable.Clear();
            return data;
        }

        public void updateDataByLogin(string Data, string Login, string column)
        {
            SqlCommand updateCmd = new SqlCommand($"UPDATE USERS SET {column} = @newLogin WHERE u_login = @login", LoginForm.dataBase.GetConnection());
            updateCmd.Parameters.Add("@login", SqlDbType.VarChar).Value = Login;
            updateCmd.Parameters.Add("@newLogin", SqlDbType.VarChar).Value = Data;
            LoginForm.dataBase.OpenConnection();
            updateCmd.ExecuteNonQuery();
            LoginForm.dataBase.CloseConnection();
        }
    }
}

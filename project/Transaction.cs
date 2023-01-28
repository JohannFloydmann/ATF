using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Transaction : UserControl
    {
        private string _name;
        private string _phone;
        private string _money;
        private string _date;
        private string _time;
        private Image _image;
        public Transaction()
        {
            InitializeComponent();
        }

        #region Properties      
        public string Name
        {
            get { return _name; }
            set { _name = value; nameLabel.Text = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; phoneLabel.Text = value; }
        }
        public string Money
        {
            get { return _money; }
            set { _money = value; moneyLabel.Text = value; }
        }
        public string Date
        {
            get { return _date; }
            set { _date = value; dateLabel.Text = value; }
        }
        public string Time
        {
            get { return _time; }
            set { _time = value; timeLabel.Text = value; }
        }
        public Image Image
        {
            get { return _image; }
            set { _image = value; transactionPictureBox.Image = value; }
        }
        #endregion
    }
}

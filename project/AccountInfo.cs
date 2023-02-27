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
    public partial class AccountInfo : UserControl
    {
        public bool ifEdit = false;
        private Default.Data _dataType;
        private string _data;
        public AccountInfo()
        {
            InitializeComponent();
        }

        private void infoDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!ifEdit)
            {
                ifEdit = true;
                editBox.Image = project.Properties.Resources.sign_error_icon__1_;
                this.infoDataLabel.Visible = false;
                this.editField.Visible = true;
                this.editField.Focus();
            }
            else
            {
                ifEdit = false;
                editBox.Image = project.Properties.Resources.edit;
                editField.Text = "";
                this.infoDataLabel.Visible = true;
                this.editField.Visible = false;
            }
        }

        #region Properties
        internal Default.Data DataType
        {
            get { return _dataType; }
            set { _dataType = value; infoNameLabel.Text = value.ToString(); }
        }

        internal string Data
        {
            get { return _data; }
            set { _data = value; infoDataLabel.Text = value; }
        }

        #endregion
    }
}

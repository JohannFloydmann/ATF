namespace project
{
    partial class Transaction
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.transactionPictureBox = new System.Windows.Forms.PictureBox();
            this.moneyLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.timeLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.nameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.phoneLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dateLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.transactionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionPictureBox
            // 
            this.transactionPictureBox.Image = global::project.Properties.Resources.redArrowDone;
            this.transactionPictureBox.Location = new System.Drawing.Point(2, 14);
            this.transactionPictureBox.Name = "transactionPictureBox";
            this.transactionPictureBox.Size = new System.Drawing.Size(70, 70);
            this.transactionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.transactionPictureBox.TabIndex = 11;
            this.transactionPictureBox.TabStop = false;
            // 
            // moneyLabel
            // 
            this.moneyLabel.Location = new System.Drawing.Point(233, 29);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(105, 41);
            this.moneyLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.moneyLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.moneyLabel.StateCommon.ShortText.ColorAngle = 45F;
            this.moneyLabel.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.moneyLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.moneyLabel.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.moneyLabel.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.moneyLabel.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.moneyLabel.TabIndex = 10;
            this.moneyLabel.TabStop = false;
            this.moneyLabel.Values.Text = "₸ 5000";
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.Location = new System.Drawing.Point(411, 75);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(45, 22);
            this.timeLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.timeLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.timeLabel.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.timeLabel.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.timeLabel.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.timeLabel.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.TabStop = false;
            this.timeLabel.Values.Text = "22:30";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(85, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(126, 35);
            this.nameLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.nameLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.nameLabel.StateCommon.ShortText.ColorAngle = 45F;
            this.nameLabel.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.nameLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Bold);
            this.nameLabel.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.nameLabel.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.nameLabel.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.nameLabel.TabIndex = 8;
            this.nameLabel.TabStop = false;
            this.nameLabel.Values.Text = "Денис Ш.";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Location = new System.Drawing.Point(88, 23);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(115, 26);
            this.phoneLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.phoneLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(191)))), ((int)(((byte)(247)))));
            this.phoneLabel.StateCommon.ShortText.ColorAngle = 45F;
            this.phoneLabel.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.phoneLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.phoneLabel.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.phoneLabel.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.phoneLabel.TabIndex = 7;
            this.phoneLabel.TabStop = false;
            this.phoneLabel.Values.Text = "87473219115";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.Location = new System.Drawing.Point(380, 3);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(76, 22);
            this.dateLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.dateLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.dateLabel.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dateLabel.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dateLabel.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.dateLabel.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.TabStop = false;
            this.dateLabel.Values.Text = "21.02.2023";
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.transactionPictureBox);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.dateLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(458, 98);
            ((System.ComponentModel.ISupportInitialize)(this.transactionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox transactionPictureBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel timeLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel nameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel phoneLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel dateLabel;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel moneyLabel;
    }
}

namespace project
{
    partial class AccountInfo
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
            this.infoDataLabel = new System.Windows.Forms.Label();
            this.editField = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.infoNameLabel = new System.Windows.Forms.Label();
            this.editBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.editBox)).BeginInit();
            this.SuspendLayout();
            // 
            // infoDataLabel
            // 
            this.infoDataLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoDataLabel.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.infoDataLabel.ForeColor = System.Drawing.Color.White;
            this.infoDataLabel.Location = new System.Drawing.Point(18, 50);
            this.infoDataLabel.Name = "infoDataLabel";
            this.infoDataLabel.Size = new System.Drawing.Size(451, 37);
            this.infoDataLabel.TabIndex = 12;
            this.infoDataLabel.Text = "Шамриков Денис";
            this.infoDataLabel.Click += new System.EventHandler(this.infoDataLabel_Click);
            // 
            // editField
            // 
            this.editField.Location = new System.Drawing.Point(95, 50);
            this.editField.MaxLength = 30;
            this.editField.Name = "editField";
            this.editField.Size = new System.Drawing.Size(300, 43);
            this.editField.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.editField.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(102)))), ((int)(((byte)(38)))));
            this.editField.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.editField.StateCommon.Border.ColorAngle = 45F;
            this.editField.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.editField.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editField.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.editField.StateCommon.Border.Rounding = 10;
            this.editField.StateCommon.Border.Width = 2;
            this.editField.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.editField.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.editField.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.editField.TabIndex = 1;
            this.editField.Visible = false;
            // 
            // infoNameLabel
            // 
            this.infoNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoNameLabel.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold);
            this.infoNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(102)))), ((int)(((byte)(38)))));
            this.infoNameLabel.Location = new System.Drawing.Point(17, -1);
            this.infoNameLabel.Name = "infoNameLabel";
            this.infoNameLabel.Size = new System.Drawing.Size(457, 45);
            this.infoNameLabel.TabIndex = 15;
            this.infoNameLabel.Text = "Имя";
            this.infoNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editBox
            // 
            this.editBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.editBox.Image = global::project.Properties.Resources.edit;
            this.editBox.Location = new System.Drawing.Point(450, 58);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(20, 20);
            this.editBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editBox.TabIndex = 14;
            this.editBox.TabStop = false;
            this.editBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.infoNameLabel);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.editField);
            this.Controls.Add(this.infoDataLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AccountInfo";
            this.Size = new System.Drawing.Size(490, 106);
            ((System.ComponentModel.ISupportInitialize)(this.editBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label infoDataLabel;
        internal ComponentFactory.Krypton.Toolkit.KryptonTextBox editField;
        internal System.Windows.Forms.Label infoNameLabel;
        internal System.Windows.Forms.PictureBox editBox;
    }
}
